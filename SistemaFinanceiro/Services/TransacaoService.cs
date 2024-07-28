using SistemaFinanceiro.Model;
using SistemaFinanceiro.Data;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Data.Entity;

namespace SistemaFinanceiro.Services
{
    public class TransacaoService
    {
        private SistemaFinanceiroContext _context;

        public TransacaoService(SistemaFinanceiroContext context)
        {
            _context = context;
        }

        public Transacao ObterUltimaTransacaoPorEmail(string email)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email);
            if (usuario == null)
            {
                throw new ArgumentException("Usuário não encontrado.");
            }

            return _context.Transacoes
                .Where(t => t.UsuarioId == usuario.UsuarioId)
                .OrderByDescending(t => t.DataTransacao)
                .FirstOrDefault();
        }

        public TransacaoService() : this(new SistemaFinanceiroContext())
        {
        }

        public IEnumerable<dynamic> ObterTransacoesPorData(DateTime dataBusca, int usuarioId)
        {
            return _context.Transacoes
                .Where(t => DbFunctions.TruncateTime(t.DataTransacao) == dataBusca.Date && t.UsuarioId == usuarioId)
                .Select(t => new
                {
                    t.TransacaoId,
                    t.Valor,
                    t.Categoria,
                    t.DataTransacao,
                    t.Descricao,
                    t.TipoTransacao
                })
                .ToList();
        }

        public IEnumerable<dynamic> ObterTransacoesPorMes(int usuarioId, DateTime dataBusca)
        {
            return _context.Transacoes
                .Where(t => t.DataTransacao.Month == dataBusca.Month && t.DataTransacao.Year == dataBusca.Year && t.UsuarioId == usuarioId)
                .Select(t => new
                {
                    t.TransacaoId,
                    t.Valor,
                    t.Categoria,
                    t.DataTransacao,
                    t.Descricao,
                    t.TipoTransacao
                })
                .ToList();
        }

        public bool VerificarDataExistente(DateTime dataBusca)
        {
            return _context.Transacoes.Any(t => DbFunctions.TruncateTime(t.DataTransacao) == dataBusca.Date);
        }

        public void ExcluirTransacao(int transacaoId)
        {
            var transacao = _context.Transacoes.FirstOrDefault(t => t.TransacaoId == transacaoId);
            if (transacao != null)
            {
                _context.Transacoes.Remove(transacao);
                _context.SaveChanges();
            }
        }

        public Transacao BuscarTransacaoPorId(int transacaoId)
        {
            return _context.Transacoes.Find(transacaoId);
        }

        public bool AtualizarTransacao(int transacaoId, string categoria, string tipoTransacao, string descricao)
        {
            var transacao = _context.Transacoes.FirstOrDefault(t => t.TransacaoId == transacaoId);
            if (transacao != null)
            {
                transacao.Categoria = categoria;
                transacao.TipoTransacao = tipoTransacao;
                transacao.Descricao = descricao;
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Transacao> ObterTransacoesPorRelatorio(int usuarioId, DateTime dataInicio, DateTime dataFim)
        {
            using (var context = new SistemaFinanceiroContext())
            {
                return context.Transacoes
                    .Where(t => DbFunctions.TruncateTime(t.DataTransacao) >= dataInicio
                                && DbFunctions.TruncateTime(t.DataTransacao) <= dataFim
                                && t.UsuarioId == usuarioId)
                    .ToList();
            }
        }
    }
}
