using SistemaFinanceiro.Services;
using SistemaFinanceiro.Model;
using System;

namespace SistemaFinanceiro.Controllers
{
    public class DepositarController
    {
        private readonly DepositarService _depositarService;
        private readonly string _emailUsuario;
        private decimal _saldoUsuario;

        public DepositarController(string email, decimal saldo, DepositarService depositarService)
        {
            _emailUsuario = email;
            _saldoUsuario = saldo;
            _depositarService = depositarService;
        }

        public string RealizarDeposito(decimal valorDeposito, string descricao)
        {
            return _depositarService.RealizarDeposito(_emailUsuario, valorDeposito, descricao);
        }

        public decimal ObterSaldoAtual()
        {
            return _saldoUsuario;
        }
    }
}
