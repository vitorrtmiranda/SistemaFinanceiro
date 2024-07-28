using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    [Table("Transacoes")]
    public class Transacao
    {
        [Key]
        public int TransacaoId { get; set; }
        public int UsuarioId { get; set; }
        public decimal Valor { get; set; }
        public string Categoria { get; set; }
        public DateTime DataTransacao { get; set; }
        public string Descricao { get; set; }
        public string TipoTransacao { get; set; }
        public Usuario Usuario { get; set; }
    }
}
