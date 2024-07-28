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

namespace SistemaFinanceiro.Cadastros
{
    public partial class Editar : Form
    {
        private int transacaoId;
        private string categoria;
        private string tipoTransacao;
        private string descricao;
        private TransacaoController _transacaoController;
        private MostraDadosDia parentForm;
        private MostraDadosMes parentForm2;
        public Editar(int transacaoId, string categoria, string tipoTransacao, string descricao, MostraDadosDia parentForm)
        {
            InitializeComponent();
            this.transacaoId = transacaoId;
            this.parentForm = parentForm;

            _transacaoController = new TransacaoController(new SistemaFinanceiroContext());

            // Preencher os campos com os valores da transação
            cbCategoria.Text = categoria;
            cbTransacao.Text = tipoTransacao;
            txtDescricao.Text = descricao;
        }

        public Editar(int transacaoId, string categoria, string tipoTransacao, string descricao, MostraDadosMes parentForm)
        {
            InitializeComponent();
            this.transacaoId = transacaoId;
            parentForm2 = parentForm;

            _transacaoController = new TransacaoController(new SistemaFinanceiroContext());

            // Preencher os campos com os valores da transação
            cbCategoria.Text = categoria;
            cbTransacao.Text = tipoTransacao;
            txtDescricao.Text = descricao;
        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarEdicao_Click(object sender, EventArgs e)
        {
            // Confirmar edição
            DialogResult result = MessageBox.Show("Tem certeza que deseja editar esta transação?", "Confirmação de Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool sucesso = _transacaoController.AtualizarTransacao(transacaoId, cbCategoria.Text, cbTransacao.Text, txtDescricao.Text);

                if (sucesso)
                {
                    MessageBox.Show("Edição realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Verificar qual parentForm foi passado e chamar a função correspondente
                    if (parentForm != null)
                    {
                        parentForm.CarregarTransacoes(parentForm.dataBusca);
                    }
                    else if (parentForm2 != null)
                    {
                        parentForm2.CarregarTransacoes(parentForm2.dataBusca);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar alterações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
