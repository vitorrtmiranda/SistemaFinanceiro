using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaFinanceiro.Services
{
    public class RelatorioService
    {
        private readonly SistemaFinanceiroContext _context;

        public RelatorioService(SistemaFinanceiroContext context)
        {
            _context = context;
        }
        
        public void AtualizarSaldo(Usuario usuario, decimal novoSaldo)
        {
            usuario.Saldo = novoSaldo;
            _context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public Relatorio ObterRelatorioExistente(DateTime dataInicio, DateTime dataFim, int usuarioId)
        {
            return _context.Relatorios
                .FirstOrDefault(r => r.DataInicio == dataInicio && r.DataFim == dataFim && r.UsuarioId == usuarioId);
        }

        public void AdicionarOuSubstituirRelatorio(Relatorio novoRelatorio)
        {
            var relatorioExistente = ObterRelatorioExistente(novoRelatorio.DataInicio, novoRelatorio.DataFim, novoRelatorio.UsuarioId);

            if (relatorioExistente != null)
            {
                _context.Relatorios.Remove(relatorioExistente);
            }

            _context.Relatorios.Add(novoRelatorio);
            _context.SaveChanges();
        }

        public decimal CalcularSaldoPeriodo(DateTime dataInicio, DateTime dataFim, string tipoTransacao)
        {
            // Ajuste para incluir o final do dia, se necessário
            if (tipoTransacao == "Depósito")
            {
                return _context.Transacoes
                    .Where(t => t.DataTransacao >= dataInicio && t.DataTransacao <= dataFim && t.TipoTransacao == tipoTransacao)
                    .Sum(t => t.Valor);
            }

            // Se você tiver outros tipos de transações, adicione lógica aqui
            return 0;
        }

        public decimal CalcularTotal(DateTime dataInicio, DateTime dataFim)
        {
            // Depuração
            Console.WriteLine($"CalcularTotal: DataInicio={dataInicio}, DataFim={dataFim}");

            var transacoes = _context.Transacoes
                .Where(t => t.DataTransacao >= dataInicio && t.DataTransacao <= dataFim)
                .ToList();

            // Log de transações encontradas
            Console.WriteLine($"Transações encontradas: {transacoes.Count}");
            foreach (var t in transacoes)
            {
                Console.WriteLine($"Transação: Valor={t.Valor}");
            }

            return transacoes.Sum(t => (decimal?)t.Valor) ?? 0m;
        }

        public bool RelatorioExiste(DateTime dataInicio, DateTime dataFim, string categoria)
        {
            return _context.Relatorios
                .Any(r => r.DataInicio == dataInicio && r.DataFim == dataFim && r.Categoria == categoria);
        }

        public List<Relatorio> ObterRelatorios(int usuarioId)
        {
            return _context.Relatorios
                .Where(r => r.UsuarioId == usuarioId)
                .ToList();
        }


    }
}
