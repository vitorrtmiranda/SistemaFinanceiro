using SistemaFinanceiro.Model;
using SistemaFinanceiro.Data;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Security.Cryptography;
using System.Text;

namespace SistemaFinanceiro.Services
{
    public class UsuarioService
    {
        private readonly SistemaFinanceiroContext _context;

        public UsuarioService(SistemaFinanceiroContext context)
        {
            _context = context;
        }

        public bool ValidarEmail(string email)
        {
            // Simples validação de e-mail
            return email.Contains("@");
        }

        public Usuario ObterUsuarioPorEmailESenha(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario ObterUsuarioPorEmail(string email)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Email == email);
        }

        public Usuario CriarUsuario(string email, string senha)
        {
            if (!ValidarEmail(email))
            {
                throw new ArgumentException("Email inválido.");
            }

            var usuario = new Usuario
            {
                Email = email,
                Senha = CriptografarSenha(senha), // Em uma aplicação real, nunca armazene senhas em texto claro
                Saldo = 0.0m
            };

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return usuario;
        }

        public bool VerificarSenha(string senhaDigitada, string senhaArmazenada)
        {
            string senhaCriptografada = CriptografarSenha(senhaDigitada);
            return senhaCriptografada == senhaArmazenada;
        }

        public void AtualizarSaldo(string email, decimal novoSaldo)
        {
            var usuario = ObterUsuarioPorEmail(email);
            if (usuario == null)
            {
                throw new ArgumentException("Usuário não encontrado.");
            }

            usuario.Saldo = novoSaldo;
            _context.SaveChanges();
        }

        private string CriptografarSenha(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
