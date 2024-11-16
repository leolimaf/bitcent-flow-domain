namespace BitcentFlow.Domain.Entities;

public class TransacaoFinanceira
{
    public Guid Id { get; set; }
    public string? Descricao { get; set; }
    public DateTime Data { get; set; }
    public decimal Valor { get; set; }
    public TipoTransacao Tipo { get; set; }

    public enum TipoTransacao
    {
        RECEITA = 1,
        DESPESA = 2
    }
}