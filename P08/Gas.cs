namespace Abastecimento;

public class Gas : Abastecimentos {
    // Método Construtor de Gas
    public Gas(string nome, decimal ValorInicial) : base(nome, ValorInicial) {}

    public override void ExecutarAcrescimo () {
        decimal acrescimo = ValorAcumulado/100; // 1%

        EfetuarPagamento(acrescimo, DateTime.Now, "Acréscimo com Gas.");
    }
}