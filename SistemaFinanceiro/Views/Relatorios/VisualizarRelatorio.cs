using SistemaFinanceiro.Controllers;
using SistemaFinanceiro.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaFinanceiro.Relatorios
{
    public partial class VisualizarRelatorio : Form
    {
        public int UsuarioId { get; set; }
        private readonly RelatorioController _relatorioController;

        public VisualizarRelatorio(int usuarioId, RelatorioController relatorioController)
        {
            InitializeComponent();
            UsuarioId = usuarioId;
            _relatorioController = relatorioController; // Inicializa o controlador
        }

        private void VisualizarRelatorio_Load(object sender, EventArgs e)
        {
            CarregarRelatorios();
        }

        private void CarregarRelatorios()
        {
            try
            {
                var relatorios = _relatorioController.ObterRelatorios(UsuarioId);
                dgvMostraRelatoriosDisponiveis.DataSource = relatorios;

                dgvMostraRelatoriosDisponiveis.Columns[0].HeaderText = "Tipo de Relatório";
                dgvMostraRelatoriosDisponiveis.Columns[1].HeaderText = "Data de Início";
                dgvMostraRelatoriosDisponiveis.Columns[2].HeaderText = "Data Final";

                dgvMostraRelatoriosDisponiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvMostraRelatoriosDisponiveis.ScrollBars = ScrollBars.Both;
                dgvMostraRelatoriosDisponiveis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar os relatórios: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMostraRelatoriosDisponiveis.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um relatório para visualizar os detalhes.", "Nenhum Relatório Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var linhaSelecionada = dgvMostraRelatoriosDisponiveis.SelectedRows[0];
                var tipoRelatorio = linhaSelecionada.Cells["TipoRelatorio"].Value.ToString();
                var dataInicio = (DateTime)linhaSelecionada.Cells["DataInicio"].Value;
                var dataFim = (DateTime)linhaSelecionada.Cells["DataFim"].Value;

                var transacoes = _relatorioController.ObterTransacoesPorRelatorio(UsuarioId, dataInicio, dataFim);
                dgvMostraRelatoriosSelecionados.DataSource = transacoes;

                dgvMostraRelatoriosSelecionados.Columns["Valor"].HeaderText = "Valor da transação";
                dgvMostraRelatoriosSelecionados.Columns["Categoria"].HeaderText = "Categoria";
                dgvMostraRelatoriosSelecionados.Columns["DataTransacao"].HeaderText = "Data da Transação";
                dgvMostraRelatoriosSelecionados.Columns["Descricao"].HeaderText = "Descrição";

                dgvMostraRelatoriosSelecionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvMostraRelatoriosSelecionados.ScrollBars = ScrollBars.Both;
                dgvMostraRelatoriosSelecionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar os detalhes do relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
