using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    [Table("Relatorios")]
    public class Relatorio
    {
        [Key]
        public int RelatorioId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal SaldoPeriodo { get; set; }
        public string Categoria { get; set; }
        public decimal Total { get; set; }
    }
}
