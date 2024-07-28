using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using System.Linq;

namespace SistemaFinanceiro.Controllers
{
    public class PerfilController
    {
        private string _senhaUsuario;
        private string _emailUsuario;
        private SistemaFinanceiroContext _context;

        public PerfilController(string email, string senha, SistemaFinanceiroContext context)
        {
            _emailUsuario = email;
            _senhaUsuario = senha;
            _context = context;
        }

        public Usuario ObterUsuario()
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == _emailUsuario);
            if (usuario != null)
            {
                return new Usuario
                {
                    Email = usuario.Email,
                    Senha = usuario.Senha,
                    Saldo = usuario.Saldo
                };
            }
            return null;
        }

        public string MostrarSenha()
        {
            return _senhaUsuario;
        }

        public string AtualizarSenha(string senhaAtual, string novaSenha)
        {
            if (VerificarSenha(senhaAtual))
            {
                if (!string.IsNullOrEmpty(novaSenha))
                {
                    var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == _emailUsuario);
                    if (usuario != null)
                    {
                        usuario.Senha = CriptografarSenha(novaSenha);
                        _context.SaveChanges();
                        _senhaUsuario = usuario.Senha;
                        return "Sucesso";
                    }
                }
                return "Por favor, preencha o campo de nova senha.";
            }
            return "Senha atual incorreta.";
        }

        private string CriptografarSenha(string senha)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha));
                return string.Concat(bytes.Select(b => b.ToString("x2")));
            }
        }

        private bool VerificarSenha(string senhaDigitada)
        {
            string senhaCriptografada = CriptografarSenha(senhaDigitada);
            return senhaCriptografada == _senhaUsuario;
        }
    }
}
