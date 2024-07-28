using SistemaFinanceiro.Controllers;
using System;
using System.Windows.Forms;

namespace SistemaFinanceiro.Perfil
{
    public partial class Perfil : Form
    {
        private PerfilController _controller;

        public Perfil(PerfilController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            AtualizarLabels();
        }

        private void AtualizarLabels()
        {
            var usuario = _controller.ObterUsuario();
            if (usuario != null)
            {
                // Inicializa o lblSenha com asteriscos
                lblSenha.Text = new string('*', _controller.MostrarSenha().Length);
            }
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
            {
                // Mostrar a senha real
                lblSenha.Text = _controller.MostrarSenha();
            }
            else
            {
                // Mostrar a senha como asteriscos
                lblSenha.Text = new string('*', _controller.MostrarSenha().Length);
            }
        }

        private void btnAttSenha_Click(object sender, EventArgs e)
        {
            var resultado = _controller.AtualizarSenha(txtSenhaAtual.Text, txtNovaSenha.Text);

            if (resultado == "Sucesso")
            {
                MessageBox.Show("Senha atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(resultado, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
