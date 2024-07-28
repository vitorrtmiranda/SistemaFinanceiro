using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace SistemaFinanceiro.Services
{
    public class ConsultarService
    {
        public bool VerificarTransacoesParaData(DateTime data)
        {
            using (var context = new SistemaFinanceiroContext())
            {
                return context.Transacoes.Any(t => DbFunctions.TruncateTime(t.DataTransacao) == data.Date);
            }
        }

        public Usuario BuscarUsuarioPorEmail(string email)
        {
            using (var context = new SistemaFinanceiroContext())
            {
                return context.Usuarios.FirstOrDefault(u => u.Email == email);
            }
        }
    }
}
