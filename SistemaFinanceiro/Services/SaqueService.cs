using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using System;
using System.Linq;

namespace SistemaFinanceiro.Services
{
    public class SaqueService
    {
        public void RealizarSaque(string email, string senha, decimal valorSaque, string descricao)
        {
            using (var context = new SistemaFinanceiroContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);

                if (usuario != null)
                {
                    if (valorSaque <= 0)
                    {
                        throw new ArgumentException("O valor do saque deve ser positivo.");
                    }

                    if (valorSaque > usuario.Saldo)
                    {
                        throw new InvalidOperationException("Saldo insuficiente.");
                    }

                    // Calcula o novo saldo
                    decimal novoSaldo = usuario.Saldo - valorSaque;

                    // Cria uma nova transação
                    Transacao novaTransacao = new Transacao
                    {
                        UsuarioId = usuario.UsuarioId,
                        Valor = valorSaque,
                        Categoria = "Saque",
                        DataTransacao = DateTime.Now,
                        Descricao = descricao,
                        TipoTransacao = "Saque",
                        Usuario = usuario
                    };

                    // Adiciona a nova transação no banco de dados
                    context.Transacoes.Add(novaTransacao);
                    usuario.Saldo = novoSaldo;

                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Usuário não encontrado.");
                }
            }
        }
    }
}
