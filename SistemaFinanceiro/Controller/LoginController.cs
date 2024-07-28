using SistemaFinanceiro.Services;
using SistemaFinanceiro.Model;
using System;
using System.Windows.Forms;

namespace SistemaFinanceiro.Controllers
{
    public class LoginController
    {
        private readonly UsuarioService _usuarioService;
        private readonly FrmLogin _view;

        public LoginController(UsuarioService usuarioService, FrmLogin view)
        {
            _usuarioService = usuarioService;
            _view = view;
        }

        public void OnLoginClicked(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        public void OnEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }

        private void ChamarLogin()
        {
            string email = _view.Email;
            string senha = _view.Senha;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha os Campos Corretamente");
                _view.FocusOnEmail();
                return;
            }

            if (!_usuarioService.ValidarEmail(email))
            {
                MessageBox.Show("Endereço de email inválido.");
                _view.FocusOnEmail();
                return;
            }

            var usuario = _usuarioService.ObterUsuarioPorEmail(email);

            if (usuario == null)
            {
                usuario = _usuarioService.CriarUsuario(email, senha);
                MessageBox.Show("Usuário criado com sucesso!");
            }
            else
            {
                if (!_usuarioService.VerificarSenha(senha, usuario.Senha))
                {
                    MessageBox.Show("Senha incorreta");
                    _view.FocusOnEmail();
                    return;
                }
            }

            FrmMenu form = new FrmMenu
            {
                UsuarioEmail = usuario.Email,
                UsuarioSaldo = usuario.Saldo,
                UsuarioSenha = usuario.Senha,
            };

            _view.Hide();
            form.ShowDialog();
            _view.Close();
        }
    }
}
