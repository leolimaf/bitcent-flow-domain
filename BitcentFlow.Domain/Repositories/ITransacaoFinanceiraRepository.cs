using BitcentFlow.Domain.Entities;

namespace BitcentFlow.Domain.Repositories;

public interface ITransacaoFinanceiraRepository
{
    Task AdicionarAsync(TransacaoFinanceira transacao);
    Task<TransacaoFinanceira?> ObterPorIdAsync(Guid id);
    Task<List<TransacaoFinanceira>> ListarAsync();
    void Remover(TransacaoFinanceira transacao);
    Task<int> SalvarAlteracoesAsync();
}