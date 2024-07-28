using SistemaFinanceiro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaFinanceiro.Cadastros
{
    public partial class MostraDadosMes : Form
    {
        private int usuarioId;
        private string senhaUsuario;
        private string emailUsuario;
        private decimal saldoUsuario;
        public DateTime dataBusca;
        private TextBox editingTextBox;
        private TransacaoController _transacaoController;

        public MostraDadosMes(int usuarioId, DateTime selectedDate)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            _transacaoController = new TransacaoController(new SistemaFinanceiroContext());

            // Configurar o DataGridView
            dgvMostraDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CarregarTransacoes(selectedDate);
        }

        public MostraDadosMes(int usuarioId, string emailUsuario, string senhaUsuario, decimal saldoUsuario, DateTime selectedDate)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            this.emailUsuario = emailUsuario;
            this.senhaUsuario = senhaUsuario;
            this.saldoUsuario = saldoUsuario;
            this.dataBusca = selectedDate;
            _transacaoController = new TransacaoController(new SistemaFinanceiroContext());

            // Configurar o DataGridView
            dgvMostraDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CarregarTransacoes(selectedDate);
        }

        public void SetTransacoes(IEnumerable<dynamic> transacoes)
        {
            dgvMostraDados.DataSource = transacoes.ToList();
        }

        public void CarregarTransacoes(DateTime dataBusca)
        {
            var transacoes = _transacaoController.ObterTransacoesPorData(dataBusca, usuarioId);

            // Definir o DataSource do DataGridView
            dgvMostraDados.DataSource = transacoes.Select(t => new
            {
                t.TransacaoId,
                t.Valor,
                t.Categoria,
                t.DataTransacao,
                t.Descricao,
                t.TipoTransacao
            }).ToList();

            dgvMostraDados.DataSource = transacoes;
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
                        _transacaoController.ExcluirTransacao(transacaoId);
                        CarregarTransacoes(DateTime.Now); // Atualizar a lista após exclusão
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
                editarTransacaoForm.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma transação para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MostraDadosMes_Load(object sender, EventArgs e)
        {
            dgvMostraDados.EditMode = DataGridViewEditMode.EditOnEnter;
        }
    }
}
