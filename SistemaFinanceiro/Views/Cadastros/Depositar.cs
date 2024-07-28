using SistemaFinanceiro.Controllers;
using SistemaFinanceiro.Data;
using SistemaFinanceiro.Services;
using System;
using System.Windows.Forms;

namespace SistemaFinanceiro.Cadastros
{
    public partial class Depositar : Form
    {
        private readonly DepositarController _controller;

        public Depositar(string email, decimal saldo)
        {
            InitializeComponent();
            var context = new SistemaFinanceiroContext();
            var service = new DepositarService(context);
            _controller = new DepositarController(email, saldo, service);
            lblSaldoAtual.Text = saldo.ToString("F2");
        }

        private void btnConfirmarDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtDepositar.Text, out decimal valorDeposito))
                {
                    string resultado = _controller.RealizarDeposito(valorDeposito, txtDescricao.Text);
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (resultado == "Depósito realizado com sucesso!")
                    {
                        // Atualizar o FrmMenu
                        if (Application.OpenForms["FrmMenu"] is FrmMenu frmMenu)
                        {
                            frmMenu.AtualizarSaldo(_controller.ObterSaldoAtual());
                        }
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, digite um valor de depósito válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao realizar o depósito: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
