using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using SistemaFinanceiro.Services;
using System;

namespace SistemaFinanceiro.Controllers
{
    public class FrmMenuController
    {
        private FrmMenu _view;
        private UsuarioService _usuarioService;
        private TransacaoService _transacaoService;

        public FrmMenuController(FrmMenu view, UsuarioService usuarioService, TransacaoService transacaoService)
        {
            _view = view;
            _usuarioService = usuarioService;
            _transacaoService = transacaoService;

            _view.Load += FrmMenu_Load;
            _view.Activated += FrmMenu_Activated;
        }

        public void FrmMenu_Load(object sender, EventArgs e)
        {
            _view.pnlEsquerda.BackColor = System.Drawing.Color.FromArgb(100, 83, 71);
            _view.pnlDireita.BackColor = System.Drawing.Color.FromArgb(100, 83, 71);

            // Inicializa o Timer ao carregar o formulário
            _view.InitializeTimer();
            _view.lblDataAtual.Text = "Carregando...";
            _view.lblHoraAtual.Text = "Carregando...";
            AtualizarDadosUsuario();
            AtualizarMovimentacaoDoDia();
        }

        public void FrmMenu_Activated(object sender, EventArgs e)
        {
            AtualizarDadosUsuario();
            AtualizarMovimentacaoDoDia();
        }

        public void AtualizarDadosUsuario()
        {
            var usuario = _usuarioService.ObterUsuarioPorEmail(_view.UsuarioEmail);
            if (usuario != null)
            {
                _view.UsuarioEmail = usuario.Email;
                _view.UsuarioSaldo = usuario.Saldo;
                _view.UsuarioSenha = usuario.Senha;
                _view.UsuarioId = usuario.UsuarioId;
                _view.AtualizarSaldo(usuario.Saldo);
                _view.lblUsuario.Text = "Olá, " + usuario.Email;
                _view.lblSaldoAtual.Text = usuario.Saldo.ToString("C");
            }
            else
            {
                _view.MostrarErro("Usuário não encontrado.");
            }
        }

        public void AtualizarMovimentacaoDoDia()
        {
            var transacao = _transacaoService.ObterUltimaTransacaoPorEmail(_view.UsuarioEmail);
            if (transacao != null)
            {
                _view.lblMovimentacaoDoDia.Text = transacao.Valor.ToString("C");
                _view.lblIdentificador.Text = transacao.TipoTransacao;
            }
            else
            {
                _view.lblMovimentacaoDoDia.Text = "Nenhuma movimentação recente";
                _view.lblIdentificador.Text = "N/A";
            }
        }

        public void MenuSair_Click(object sender, EventArgs e)
        {
            var form = new FrmLogin();
            _view.Hide();
            form.ShowDialog();
            _view.Close();
        }

        public void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Cadastros.FrmConsultar(_view.UsuarioId, _view.UsuarioEmail, _view.UsuarioSenha, _view.UsuarioSaldo);
            form.ShowDialog();
        }

        public void VisualizarRelatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crie a instância do contexto
            using (var context = new SistemaFinanceiroContext())
            {
                // Crie a instância do serviço e controlador necessários
                var relatorioService = new RelatorioService(context); // Passe o contexto para o serviço
                var relatorioController = new RelatorioController(relatorioService); // Passe o serviço para o controlador

                // Crie o formulário passando o controlador e o UserId
                var form = new Relatorios.VisualizarRelatorio(_view.UsuarioId, relatorioController);
                form.ShowDialog();
            }
        }

        public void FazerRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Relatorios.Relatorios(_view.UsuarioId);
            form.ShowDialog();
        }
    }
}
