using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaFinanceiro.Controllers;
using SistemaFinanceiro.Data;
using SistemaFinanceiro.Services;

namespace SistemaFinanceiro
{
    public partial class FrmLogin : Form
    {
        private LoginController _controller;

        public FrmLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = true;
        }

        public string Email => txtUsuario.Text.Trim();
        public string Senha => txtSenha.Text.Trim();

        

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            CenterLoginPanel();
        }

        private void CenterLoginPanel()
        {
            pnlLogin.Left = (this.ClientSize.Width - pnlLogin.Width) / 2;
            pnlLogin.Top = (this.ClientSize.Height - pnlLogin.Height) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_controller != null)
            {
                _controller.OnLoginClicked(this, EventArgs.Empty); // Chamar diretamente o método do controlador
            }
            else
            {
                MessageBox.Show("O controlador não foi inicializado.");
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (_controller != null && e.KeyCode == Keys.Enter)
            {
                _controller.OnEnterPressed(this, e); // Chamar diretamente o método do controlador
            }
        }

        public void FocusOnEmail()
        {
            txtUsuario.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CenterLoginPanel();
            // Instanciar o controlador aqui
            _controller = new LoginController(new UsuarioService(new SistemaFinanceiroContext()), this);
        }
    }
}
