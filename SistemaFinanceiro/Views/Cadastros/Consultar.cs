using SistemaFinanceiro.Controllers;
using SistemaFinanceiro.Data;
using System;
using System.Windows.Forms;

namespace SistemaFinanceiro.Cadastros
{
    public partial class FrmConsultar : Form
    {
        private int usuarioId;
        private string senhaUsuario;
        private string emailUsuario;
        private decimal saldoUsuario;
        private readonly ConsultarController _consultaController;

        public FrmConsultar(int usuarioId, string email, string senha, decimal saldo)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            this.senhaUsuario = senha;
            this.emailUsuario = email;
            this.saldoUsuario = saldo;
            _consultaController = new ConsultarController();
        }

        public FrmConsultar() : this(0, "", "", 0) { }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            // Popula o ComboBox com os meses
            cbMeses.Items.AddRange(new string[]
            {
                "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
            });
            cbMeses.SelectedIndex = -1; // Nenhum mês selecionado por padrão
        }

        private void btnBuscaMes_Click(object sender, EventArgs e)
        {
            int selectedMonth = cbMeses.SelectedIndex + 1; // +1 porque o índice do combo box começa em 0

            if (selectedMonth == 0)
            {
                MessageBox.Show("Selecione um mês válido para realizar a busca.");
                return;
            }

            DateTime selectedDate = new DateTime(DateTime.Now.Year, selectedMonth, 1);

            // Instanciar o controller e buscar as transações
            var context = new SistemaFinanceiroContext(); // Ou injete o contexto conforme sua arquitetura
            var transacaoController = new TransacaoController(context);
            var transacoes = transacaoController.ObterTransacoesPorMes(selectedDate, usuarioId);

            // Instanciar e exibir o formulário MostraDadosMes
            MostraDadosMes mostraDadosMesForm = new MostraDadosMes(usuarioId, emailUsuario, senhaUsuario, saldoUsuario, selectedDate);
            mostraDadosMesForm.SetTransacoes(transacoes); // Definir transações no formulário
            mostraDadosMesForm.ShowDialog();
        }


        private void btnBuscaData_Click(object sender, EventArgs e)
        {
            DateTime parsedDate;
            bool isValidDate = DateTime.TryParseExact(buscaDataTxt.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            if (!isValidDate)
            {
                MessageBox.Show("Data inválida. Por favor, insira uma data no formato dd/MM/yyyy.");
                buscaDataTxt.Focus();
                return;
            }

            DateTime minDate = new DateTime(1900, 1, 1);
            DateTime maxDate = DateTime.Now;

            if (parsedDate < minDate || parsedDate > maxDate)
            {
                MessageBox.Show($"Data fora do intervalo permitido. Por favor, insira uma data entre {minDate.ToString("dd/MM/yyyy")} e {maxDate.ToString("dd/MM/yyyy")}.");
                buscaDataTxt.Focus();
                return;
            }

            var controller = new TransacaoController();
            if (!controller.VerificarDataExistente(parsedDate))
            {
                MessageBox.Show($"Não há transações cadastradas para a data {parsedDate.ToString("dd/MM/yyyy")}.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Data válida. Realizando busca...");
            mostraDadosDias(parsedDate);
        }

        private void mostraDadosDias(DateTime parsedDate)
        {
            var controller = new TransacaoController();
            var usuario = controller.BuscarUsuarioPorEmail(emailUsuario);

            if (usuario != null)
            {
                var transacoes = controller.ObterTransacoesPorData(parsedDate, usuario.UsuarioId);
                var formMostraDadosDia = new Cadastros.MostraDadosDia(usuario.Email, usuario.Senha, usuario.Saldo, parsedDate, usuario.UsuarioId);
                formMostraDadosDia.SetDataSource(transacoes); // Atualiza a fonte de dados do formulário
                formMostraDadosDia.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buscaDataTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Se necessário, manipule o evento de rejeição da entrada da máscara aqui.
        }

        private void buscaDataTxt_Click(object sender, EventArgs e)
        {
            buscaDataTxt.SelectionStart = 0; // Define o cursor para o primeiro caractere à esquerda
        }
    }
}
