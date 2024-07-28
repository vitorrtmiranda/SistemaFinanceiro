using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using SistemaFinanceiro.Services;
using System;

namespace SistemaFinanceiro.Controller
{
    public class UsuarioController
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public Usuario Login(string email, string senha)
        {
            // Verifica se o email e senha estão corretos
            return _usuarioService.ObterUsuarioPorEmailESenha(email, senha);
        }

        public Usuario CriarUsuario(string email, string senha)
        {
            // Cria um novo usuário e retorna o objeto criado
            return _usuarioService.CriarUsuario(email, senha);
        }

        public void AtualizarSaldo(string email, decimal novoSaldo)
        {
            // Atualiza o saldo do usuário
            _usuarioService.AtualizarSaldo(email, novoSaldo);
        }

        public Usuario ObterUsuarioPorEmail(string email)
        {
            // Obtém o usuário baseado no email
            return _usuarioService.ObterUsuarioPorEmail(email);
        }

        public bool ValidarEmail(string email)
        {
            // Valida o formato do email
            return _usuarioService.ValidarEmail(email);
        }

        public bool VerificarSenha(string senhaDigitada, string senhaArmazenada)
        {
            // Verifica se a senha digitada corresponde à senha armazenada
            return _usuarioService.VerificarSenha(senhaDigitada, senhaArmazenada);
        }
    }
}
