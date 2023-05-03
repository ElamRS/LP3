namespace Abastecimento;

public class Gasolina : Abastecimentos {
    // Método Construtor de Gasolina
    public Gasolina(string nome, decimal ValorInicial) : base(nome, ValorInicial) {}

    public override void ExecutarAcrescimo () {
        decimal acrescimo = ValorAcumulado/100; // 1%

        EfetuarPagamento(acrescimo, DateTime.Now, "Acréscimo com Gasolina.");
    }
}