using SistemaFinanceiro.Controllers;
using System;
using System.Windows.Forms;

namespace SistemaFinanceiro.Cadastros
{
    public partial class Sacar : Form
    {
        private string senhaUsuario;
        private string emailUsuario;
        private decimal saldoUsuario;
        private SaqueController _saqueController;

        public Sacar(string email, string senha, decimal saldo)
        {
            InitializeComponent();
            senhaUsuario = senha;
            emailUsuario = email;
            saldoUsuario = saldo;
            lblSaldoAtual.Text = saldoUsuario.ToString("C");
            _saqueController = new SaqueController();
        }

        private void btnConfirmarSaque_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtSacar.Text, out decimal valorSaque))
                {
                    _saqueController.RealizarSaque(emailUsuario, senhaUsuario, valorSaque, txtDescricaoSacar.Text);
                    MessageBox.Show("Saque realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    // Atualiza o FrmMenu
                    if (Application.OpenForms["FrmMenu"] is FrmMenu frmMenu)
                    {
                        frmMenu.AtualizarSaldoDoBanco();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, digite um valor de saque válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
