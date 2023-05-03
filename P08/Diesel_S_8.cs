namespace Abastecimento;

public class Diesel_S_8 : Abastecimentos {
    // Método Construtor de Diesel S-8
    public Diesel_S_8(string nome, decimal ValorInicial) : base(nome, ValorInicial) {}

    public override void ExecutarAcrescimo () {
        decimal acrescimo = (ValorAcumulado/100) * 3; // 3%

        EfetuarPagamento(acrescimo, DateTime.Now, "Acréscimo com Diesel S-8.");
    }
}