using SistemaFinanceiro.Controllers;
using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using SistemaFinanceiro.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinanceiro.Relatorios
{
    public partial class Relatorios : Form
    {
        private readonly RelatorioController _controller;
        public int usuarioId;

        public Relatorios(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            var context = new SistemaFinanceiroContext();
            var relatorioService = new RelatorioService(context);
            _controller = new RelatorioController(relatorioService, this);
        }
        public Relatorios()
        {
            InitializeComponent();
            var context = new SistemaFinanceiroContext();
            var relatorioService = new RelatorioService(context);
            _controller = new RelatorioController(relatorioService, this);
        }

        private void btnConfirmarDiario_Click(object sender, EventArgs e)
        {
            DateTime dataSelecionada = dtpRelatiroDiario.Value.Date;
            _controller.GerarRelatorioDiario(dataSelecionada, usuarioId);
        }

        private void btnConfirmarSemanal_Click(object sender, EventArgs e)
        {
            if (cbSemanal.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma semana para gerar o relatório.",
                                "Semana Não Selecionada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            int semanaSelecionada = cbSemanal.SelectedIndex;
            
            _controller.GerarRelatorioSemanal(semanaSelecionada, usuarioId);
        }

        private void btnConfirmarMensal_Click(object sender, EventArgs e)
        {
            if (cbRelatorioMensal.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma semana para gerar o relatório.",
                                "Semana Não Selecionada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            int mesSelecionado = cbRelatorioMensal.SelectedIndex + 1;
            _controller.GerarRelatorioMensal(mesSelecionado, usuarioId);
        }

        private void btnConfirmarAnual_Click(object sender, EventArgs e)
        {
            if (cbRelatorioAnual.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma semana para gerar o relatório.",
                                "Semana Não Selecionada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            int anoSelecionado = cbRelatorioAnual.SelectedIndex + 1900;
            _controller.GerarRelatorioAnual(anoSelecionado, usuarioId);
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {

        }
    }
}
