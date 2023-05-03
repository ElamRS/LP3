namespace Abastecimento;

public class Abastecimentos {
    public string Cliente { get; set; }
    public decimal ValorAcumulado
    {
        get
        {
            decimal valor = 0m;
            foreach (var abastecimento in todosAbastecimentos)
            {
                valor += abastecimento.Valor;
            } 

            return valor;
        }
    }

    public Abastecimentos(string nome, decimal ValorInicial)
    {
        this.Cliente = nome;
        EfetuarDeposito(ValorInicial, DateTime.Now, "Valor Inicial ");
    }

    private List<Transacao> todosAbastecimentos = new List<Transacao>();

    public void EfetuarDeposito(decimal valor, DateTime data, string descricao) {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "A valor de depósito deve ser positivo");
        }
        var acrescimo = new Transacao(valor, data, descricao);
        todosAbastecimentos.Add(acrescimo);
    }

    // Método responsável por realizar o pagamento da quantia 
    public void EfetuarPagamento(decimal valor, DateTime data, string descricao) {    
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), " o valor de saque deve ser positivo");
        }
        if (Valor - valor < 0)
        {
            throw new InvalidOperationException("Fundo não suficiente para este saque");
        }
        var saque = new Transacao(-valor, data, descricao);
        todosAbastecimentos.Add(saque);
    }

    public string ObterHistoricodeAbastecimentos() {
        var relatorio = new System.Text.StringBuilder();

        decimal valoracumulado = 0m;
        relatorio.AppendLine("Data           Valor  Valor Acumulado   Descrição");
        foreach (var abastecimento in todosAbastecimentos)
        {
            valoracumulado += abastecimento.Valor;
            relatorio.AppendLine($"{abastecimento.Data.ToShortDateString(),-10}{abastecimento.Valor,10}{valoracumulado,17}{"   "}{abastecimento.Descricao}");
        }

        return relatorio.ToString();
    }

    public virtual void ExecutarAcrescimo() { }
}