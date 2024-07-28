// Controllers/TransacaoController.cs
using SistemaFinanceiro.Data;
using SistemaFinanceiro.Model;
using SistemaFinanceiro.Services;
using System;
using System.Collections.Generic;
using System.Linq;

public class TransacaoController
{
    private TransacaoService _transacaoService;

    public TransacaoController(SistemaFinanceiroContext context)
    {
        _transacaoService = new TransacaoService(context);
    }
    public TransacaoController()
    {
        _transacaoService = new TransacaoService(new SistemaFinanceiroContext());
    }

    public bool VerificarDataExistente(DateTime dataBusca)
    {
        return _transacaoService.VerificarDataExistente(dataBusca);
    }

    public Usuario BuscarUsuarioPorEmail(string email)
    {
        using (var context = new SistemaFinanceiroContext())
        {
            return context.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }

    public IEnumerable<dynamic> ObterTransacoesPorData(DateTime dataBusca, int usuarioId)
    {
        return _transacaoService.ObterTransacoesPorData(dataBusca, usuarioId);
    }
    public IEnumerable<dynamic> ObterTransacoesPorMes(DateTime dataBusca, int usuarioId)
    {
        return _transacaoService.ObterTransacoesPorMes(usuarioId, dataBusca);
    }


    public void ExcluirTransacao(int transacaoId)
    {
        _transacaoService.ExcluirTransacao(transacaoId);
    }

    public Transacao BuscarTransacaoPorId(int transacaoId)
    {
        return _transacaoService.BuscarTransacaoPorId(transacaoId);
    }

    public bool AtualizarTransacao(int transacaoId, string categoria, string tipoTransacao, string descricao)
    {
        return _transacaoService.AtualizarTransacao(transacaoId, categoria, tipoTransacao, descricao);
    }
}
