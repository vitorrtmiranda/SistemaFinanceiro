using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public decimal Saldo { get; set; }
        public ICollection<Transacao> TransacoesRealizadas { get; set; }
    }
}
