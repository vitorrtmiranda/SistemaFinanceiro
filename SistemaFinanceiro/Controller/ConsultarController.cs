using SistemaFinanceiro.Model;
using SistemaFinanceiro.Services;
using System;

namespace SistemaFinanceiro.Controllers
{
    public class ConsultarController
    {
        private readonly ConsultarService _consultaService;

        public ConsultarController()
        {
            _consultaService = new ConsultarService();
        }

        public bool VerificarDataExistente(DateTime data)
        {
            return _consultaService.VerificarTransacoesParaData(data);
        }

        public Usuario BuscarUsuarioPorEmail(string email)
        {
            return _consultaService.BuscarUsuarioPorEmail(email);
        }
    }
}
