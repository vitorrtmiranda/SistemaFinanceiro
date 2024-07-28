using SistemaFinanceiro.Controllers;
using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using SistemaFinanceiro.Relatorios;
using SistemaFinanceiro.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaFinanceiro
{
    public partial class FrmMenu : Form
    {
        public Label lblSaldoAtuall;

        public string SaldoAtualText
        {
            get { return lblSaldoAtuall.Text; }
            set { lblSaldoAtual.Text = value; }
        }
        private static FrmMenu instancia; // Variável estática para armazenar a instância única do FrmMenu
        public Timer timer;
        public string UsuarioEmail { get; set; }
        public decimal UsuarioSaldo { get; set; }
        public string UsuarioSenha { get; set; }
        public int UsuarioId { get; set; }

        // Método estático para obter a instância única do FrmMenu
        public static FrmMenu ObterInstancia(string email, decimal saldo, string senha)
        {
            if (instancia == null)
            {
                instancia = new FrmMenu(email, saldo, senha);
                instancia.FormClosed += (sender, e) => instancia = null; // Limpar instância ao fechar o formulário
            }
            return instancia;
        }

        public FrmMenu(string email, decimal saldo, string senha)
        {
            InitializeComponent();

            UsuarioEmail = email;
            UsuarioSaldo = saldo;
            UsuarioSenha = senha;
        }
        public FrmMenu()
        {
            InitializeComponent();
            this.Load += FrmMenu_Load;
            this.Activated += FrmMenu_Activated;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pnlEsquerda.BackColor = Color.FromArgb(100, 83, 71);
            pnlDireita.BackColor = Color.FromArgb(100, 83, 71);

            // Inicializa o Timer ao carregar o formulário
            InitializeTimer();
            lblDataAtual.Text = "Carregando...";
            lblHoraAtual.Text = "Carregando...";
            lblUsuario.Text = "Olá, " + UsuarioEmail;
            lblSaldoAtual.Text = UsuarioSaldo.ToString("C");

            try
            {
                using (var context = new SistemaFinanceiroContext())
                {
                    var usuario = context.Usuarios.FirstOrDefault(u => u.Email == UsuarioEmail && u.Senha == UsuarioSenha);
                    UsuarioEmail = usuario.Email;
                    UsuarioSaldo = usuario.Saldo;
                    UsuarioSenha = usuario.Senha;
                    UsuarioId = usuario.UsuarioId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
            }

        }


        private void AtualizarMovimentacaoDoDia()
        {
            try
            {
                using (var context = new SistemaFinanceiroContext())
                {
                    var transacao = context.Transacoes
                        .Where(t => t.Usuario.Email == UsuarioEmail)
                        .OrderByDescending(t => t.DataTransacao)
                        .FirstOrDefault();

                    if (transacao != null)
                    {
                        lblMovimentacaoDoDia.Text = transacao.Valor.ToString("C");
                        lblIdentificador.Text = transacao.TipoTransacao;
                    }
                    else
                    {
                        lblMovimentacaoDoDia.Text = "Nenhuma movimentação recente";
                        lblIdentificador.Text = "N/A";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao buscar a movimentação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMenu_Activated(object sender, EventArgs e)
        {
            AtualizarMovimentacaoDoDia();
            AtualizarSaldoDoBanco();
        }

        public void AtualizarSaldoDoBanco()
        {
            try
            {
                using (var context = new SistemaFinanceiroContext())
                {
                    var usuario = context.Usuarios.FirstOrDefault(u => u.Email == UsuarioEmail);

                    if (usuario != null)
                    {
                        UsuarioSaldo = usuario.Saldo;
                        lblSaldoAtual.Text = UsuarioSaldo.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        public void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += new EventHandler(UpdateLabels);
            timer.Start();
        }

        private void UpdateLabels(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDataAtual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            AbrirPerfil();
        }

        private void AbrirPerfil()
        {
            using (var context = new SistemaFinanceiroContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Email == UsuarioEmail);

                if (usuario != null)
                {
                    var controller = new PerfilController(usuario.Email, usuario.Senha, context);
                    Perfil.Perfil perfilForm = new Perfil.Perfil(controller);
                    perfilForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void depositarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaFinanceiroContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Email == UsuarioEmail);

                if (usuario != null)
                {
                    var formDepositar = new Cadastros.Depositar(usuario.Email, usuario.Saldo);
                    formDepositar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sacarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSacar = new Cadastros.Sacar(UsuarioEmail, UsuarioSenha, UsuarioSaldo);
            formSacar.ShowDialog();
        }


        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formConsultar = new Cadastros.FrmConsultar(UsuarioId, UsuarioEmail, UsuarioSenha, UsuarioSaldo);
            formConsultar.ShowDialog();
        }

        public void AtualizarSaldo(decimal novoSaldo)
        {
            UsuarioSaldo = novoSaldo;
            lblSaldoAtual.Text = UsuarioSaldo.ToString("C");
        }

        public void MostrarErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void fazerRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Relatorios relatoriosForm = new Relatorios.Relatorios(UsuarioId);
            relatoriosForm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            this.Close();
            formLogin.ShowDialog();
        }

        private void visualizarRelatóriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Inicializa o serviço e o controlador
            var context = new SistemaFinanceiroContext(); // ou conforme necessário
            var relatorioService = new RelatorioService(context);
            var relatorioController = new RelatorioController(relatorioService, this); // Passa o controlador com as dependências necessárias

            // Cria o formulário passando o controlador
            var form = new Relatorios.VisualizarRelatorio(UsuarioId, relatorioController);
            form.ShowDialog();
        }
    }
}
