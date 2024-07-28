// Controllers/RelatorioController.cs
using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using SistemaFinanceiro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaFinanceiro.Controllers
{
	public class RelatorioController
	{
        private readonly RelatorioService _relatorioService;
        private readonly Form _view;
        private readonly TransacaoService _transacaoService;

        public RelatorioController(RelatorioService relatorioService, Form view)
        {
            _relatorioService = relatorioService;
            _view = view;
            _transacaoService = new TransacaoService(); // Se necessário
        }

        public RelatorioController(RelatorioService relatorioService)
        {
            _relatorioService = relatorioService;
        }

        public List<object> ObterRelatorios(int usuarioId)
        {
            using (var context = new SistemaFinanceiroContext())
            {
                var relatorios = context.Relatorios
                    .Where(r => r.UsuarioId == usuarioId)
                    .Select(r => new
                    {
                        TipoRelatorio = r.Categoria,
                        DataInicio = r.DataInicio,
                        DataFim = r.DataFim
                    })
                    .ToList();

                return relatorios.Cast<object>().ToList(); // Cast para List<object>
            }
        }

        public List<Transacao> ObterTransacoesPorRelatorio(int usuarioId, DateTime dataInicio, DateTime dataFim)
        {
            return _transacaoService.ObterTransacoesPorRelatorio(usuarioId, dataInicio, dataFim);
        }

        public void GerarRelatorioDiario(DateTime dataSelecionada, int usuarioId)
        {
            var resultado = MessageBox.Show(
                $"Você realmente deseja gerar o relatório para o dia {dataSelecionada.ToShortDateString()}?",
                "Confirmar Relatório",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            DateTime fimDoDia = dataSelecionada.Date.AddDays(1).AddTicks(-1);

            if (_relatorioService.RelatorioExiste(dataSelecionada.Date, fimDoDia, "Relatório diário"))
            {
                var substituir = MessageBox.Show(
                    "Já existe um relatório para este período. Deseja substituí-lo?",
                    "Confirmar Substituição",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (substituir == DialogResult.No)
                    return;
            }

            try
            {
                var saldoPeriodo = _relatorioService.CalcularSaldoPeriodo(dataSelecionada.Date, fimDoDia, "Depósito");
                var total = _relatorioService.CalcularTotal(dataSelecionada.Date, fimDoDia);

                var novoRelatorio = new Relatorio
                {
                    UsuarioId = usuarioId,
                    DataInicio = dataSelecionada,
                    DataFim = dataSelecionada,
                    SaldoPeriodo = saldoPeriodo,
                    Categoria = "Relatório diário",
                    Total = total
                };

                _relatorioService.AdicionarOuSubstituirRelatorio(novoRelatorio);
                MessageBox.Show("Relatório diário gerado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void GerarRelatorioSemanal(int semanaSelecionada, int usuarioId)
        {
            DateTime dataInicio, dataFim;
            DateTime hoje = DateTime.Today;

            switch (semanaSelecionada)
            {
                case 0:
                    dataInicio = new DateTime(hoje.Year, hoje.Month, 1);
                    dataFim = new DateTime(hoje.Year, hoje.Month, 7);
                    break;
                case 1:
                    dataInicio = new DateTime(hoje.Year, hoje.Month, 8);
                    dataFim = new DateTime(hoje.Year, hoje.Month, 15);
                    break;
                case 2:
                    dataInicio = new DateTime(hoje.Year, hoje.Month, 16);
                    dataFim = new DateTime(hoje.Year, hoje.Month, 23);
                    break;
                case 3:
                    dataInicio = new DateTime(hoje.Year, hoje.Month, 24);
                    dataFim = DateTime.DaysInMonth(hoje.Year, hoje.Month) == 31
                              ? new DateTime(hoje.Year, hoje.Month, 31)
                              : new DateTime(hoje.Year, hoje.Month, 30);
                    break;
                default:
                    MessageBox.Show("Seleção inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            var resultado = MessageBox.Show(
                $"Você realmente deseja gerar o relatório para a semana {semanaSelecionada + 1}?",
                "Confirmar Relatório",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            if (_relatorioService.RelatorioExiste(dataInicio, dataFim, "Relatório semanal"))
            {
                var substituir = MessageBox.Show(
                    "Já existe um relatório para este período. Deseja substituí-lo?",
                    "Confirmar Substituição",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (substituir == DialogResult.No)
                    return;
            }

            try
            {
                var saldoPeriodo = _relatorioService.CalcularSaldoPeriodo(dataInicio, dataFim, "Depósito");
                var total = _relatorioService.CalcularTotal(dataInicio, dataFim);

                var novoRelatorio = new Relatorio
                {
                    UsuarioId = usuarioId,
                    DataInicio = dataInicio,
                    DataFim = dataFim,
                    SaldoPeriodo = saldoPeriodo,
                    Categoria = "Relatório semanal",
                    Total = total
                };

                _relatorioService.AdicionarOuSubstituirRelatorio(novoRelatorio);
                MessageBox.Show("Relatório semanal gerado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        public void GerarRelatorioMensal(int mesSelecionado, int usuarioId)
		{
			DateTime hoje = DateTime.Today;
			DateTime dataInicio = new DateTime(hoje.Year, mesSelecionado, 1);
			DateTime dataFim = new DateTime(hoje.Year, mesSelecionado, DateTime.DaysInMonth(hoje.Year, mesSelecionado));

			var resultado = MessageBox.Show(
				$"Você realmente deseja gerar o relatório para o mês de {mesSelecionado}?",
				"Confirmar Relatório",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (resultado == DialogResult.No)
				return;

            if (_relatorioService.RelatorioExiste(dataInicio, dataFim, "Relatório mensal"))
            {
                var substituir = MessageBox.Show(
                    "Já existe um relatório para este período. Deseja substituí-lo?",
                    "Confirmar Substituição",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (substituir == DialogResult.No)
                    return;
            }

            try
			{
				var saldoPeriodo = _relatorioService.CalcularSaldoPeriodo(dataInicio, dataFim, "Depósito");
				var total = _relatorioService.CalcularTotal(dataInicio, dataFim);

				var novoRelatorio = new Relatorio
				{
					UsuarioId = usuarioId,
					DataInicio = dataInicio,
					DataFim = dataFim,
					SaldoPeriodo = saldoPeriodo,
					Categoria = "Relatório mensal",
					Total = total
				};

				_relatorioService.AdicionarOuSubstituirRelatorio(novoRelatorio);
				MessageBox.Show("Relatório mensal gerado com sucesso!");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void GerarRelatorioAnual(int anoSelecionado, int usuarioId)
		{
			DateTime dataInicio = new DateTime(anoSelecionado, 1, 1);
			DateTime dataFim = new DateTime(anoSelecionado, 12, 31);

			var resultado = MessageBox.Show(
				$"Você realmente deseja gerar o relatório para o ano de {anoSelecionado}?",
				"Confirmar Relatório",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (resultado == DialogResult.No)
				return;

            if (_relatorioService.RelatorioExiste(dataInicio, dataFim, "Relatório anual"))
            {
                var substituir = MessageBox.Show(
                    "Já existe um relatório para este período. Deseja substituí-lo?",
                    "Confirmar Substituição",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (substituir == DialogResult.No)
                    return;
            }

            try
			{
				var saldoPeriodo = _relatorioService.CalcularSaldoPeriodo(dataInicio, dataFim, "Depósito");
				var total = _relatorioService.CalcularTotal(dataInicio, dataFim);

				var novoRelatorio = new Relatorio
				{
					UsuarioId = usuarioId,
					DataInicio = dataInicio,
					DataFim = dataFim,
					SaldoPeriodo = saldoPeriodo,
					Categoria = "Relatório anual",
					Total = total
				};

				_relatorioService.AdicionarOuSubstituirRelatorio(novoRelatorio);
				MessageBox.Show("Relatório anual gerado com sucesso!");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
