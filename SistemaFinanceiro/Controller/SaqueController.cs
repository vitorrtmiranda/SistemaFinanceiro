using SistemaFinanceiro.Services;
using System;

namespace SistemaFinanceiro.Controllers
{
    public class SaqueController
    {
        private readonly SaqueService _saqueService;

        public SaqueController()
        {
            _saqueService = new SaqueService();
        }

        public void RealizarSaque(string email, string senha, decimal valorSaque, string descricao)
        {
            try
            {
                _saqueService.RealizarSaque(email, senha, valorSaque, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao realizar o saque: {ex.Message}", ex);
            }
        }
    }
}
