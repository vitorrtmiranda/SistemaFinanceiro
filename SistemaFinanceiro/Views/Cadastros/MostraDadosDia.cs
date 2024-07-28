using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinanceiro.Cadastros
{
    public partial class MostraDadosDia : Form
    {
        private TextBox editingTextBox;
        private string senhaUsuario;
        private string emailUsuario;
        private decimal saldoUsuario;
        private int usuarioId; // Armazena o ID do usuário logado
        public DateTime dataBusca;

        public MostraDadosDia(string email, string senha, decimal saldo, DateTime dataBusca, int usuarioId)
        {
            InitializeComponent();
            this.senhaUsuario = senha;
            this.emailUsuario = email;
            this.saldoUsuario = saldo;
            this.dataBusca = dataBusca;
            this.usuarioId = usuarioId;
            CarregarTransacoes(dataBusca);
            dgvMostraDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Método para definir a fonte de dados
        public void SetDataSource(IEnumerable<dynamic> transacoes)
        {
            dgvMostraDados.DataSource = transacoes.ToList(); // Certifique-se de converter para uma lista se necessário
        }

        public MostraDadosDia()
        {
            InitializeComponent();
            dgvMostraDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MostraDadosDia_Load(object sender, EventArgs e)
        {
            dgvMostraDados.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        public void CarregarTransacoes(DateTime dataBusca)
        {
            using (var context = new SistemaFinanceiroContext())
            {
                // Consulta as transações do dia especificado e do usuário logado
                var transacoes = context.Transacoes
                    .Where(t => DbFunctions.TruncateTime(t.DataTransacao) == dataBusca.Date && t.UsuarioId == this.usuarioId)
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

                dgvMostraDados.DataSource = transacoes;
            }
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            if (dgvMostraDados.SelectedRows.Count > 0)
            {
                var selectedRow = dgvMostraDados.SelectedRows[0];
                int transacaoId = Convert.ToInt32(selectedRow.Cells["TransacaoId"].Value);

                // Mostrar mensagem de confirmação
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta transação?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Remover a transação do banco de dados
                        using (var context = new SistemaFinanceiroContext())
                        {
                            var transacao = context.Transacoes.FirstOrDefault(t => t.TransacaoId == transacaoId);
                            if (transacao != null)
                            {
                                context.Transacoes.Remove(transacao);
                                context.SaveChanges();
                            }
                        }

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao excluir a transação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma transação para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Views/Cadastros/MostraDadosDia.cs
        private void btnEditarDados_Click(object sender, EventArgs e)
        {
            if (dgvMostraDados.SelectedRows.Count > 0)
            {
                var selectedRow = dgvMostraDados.SelectedRows[0];
                int transacaoId = Convert.ToInt32(selectedRow.Cells["TransacaoId"].Value);
                string categoria = selectedRow.Cells["Categoria"].Value?.ToString();
                string tipoTransacao = selectedRow.Cells["TipoTransacao"].Value?.ToString();
                string descricao = selectedRow.Cells["Descricao"].Value?.ToString();

                Editar editarTransacaoForm = new Editar(transacaoId, categoria, tipoTransacao, descricao, this);
                editarTransacaoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma transação para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
