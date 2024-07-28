using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using System;
using System.Linq;

namespace SistemaFinanceiro.Services
{
    public class DepositarService
    {
        private readonly SistemaFinanceiroContext _context;

        public DepositarService(SistemaFinanceiroContext context)
        {
            _context = context;
        }

        public Usuario ObterUsuarioPorEmail(string email)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Email == email);
        }

        public string RealizarDeposito(string email, decimal valorDeposito, string descricao)
        {
            var usuario = ObterUsuarioPorEmail(email);

            if (usuario == null)
                return "Usuário não encontrado.";

            if (valorDeposito <= 0)
                return "O valor do depósito deve ser maior que zero.";

            var novaTransacao = new Transacao
            {
                UsuarioId = usuario.UsuarioId,
                Valor = valorDeposito,
                Categoria = "Depósito",
                DataTransacao = DateTime.Now,
                Descricao = descricao,
                TipoTransacao = "Depósito",
                Usuario = usuario
            };

            try
            {
                usuario.Saldo += valorDeposito;
                _context.Transacoes.Add(novaTransacao);
                _context.SaveChanges();
                return "Depósito realizado com sucesso!";
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as necessary
                return $"Erro ao realizar o depósito: {ex.Message}";
            }
        }
    }
}
