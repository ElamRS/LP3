using Abastecimento;

// Gasolina
var gasolina = new Gasolina("Renato", 1000);
gasolina.EfetuarPagamento(100, DateTime.Now, "Tanque abastecido com Gasolina");
gasolina.EfetuarPagamento(200, DateTime.Now, "Tanque abastecido com Gasolina");
gasolina.ExecutarAcrescimo();
Console.WriteLine(gasolina.ObterHistoricodeAbastecimentos());

// Álcool
var alcool = new Alcool("Renato", 1000);
alcool.EfetuarPagamento(80, DateTime.Now, "Tanque abastecido com Álcool");
alcool.EfetuarPagamento(150, DateTime.Now, "Tanque abastecido com Álcool");
alcool.ExecutarAcrescimo();
Console.WriteLine(alcool.ObterHistoricodeAbastecimentos());

// Diesel S-8
var diesels8 = new Gasolina("Renato", 1000);
diesels8.EfetuarPagamento(70, DateTime.Now, "Tanque abastecido com Diesel S-8");
diesels8.EfetuarPagamento(100, DateTime.Now, "Tanque abastecido com Diesel S-8");
diesels8.ExecutarAcrescimo();
Console.WriteLine(diesels8.ObterHistoricodeAbastecimentos());

// Gás
var gas = new Gasolina("Renato", 1000);
gas.EfetuarPagamento(50, DateTime.Now, "Tanque abastecido com Gás");
gas.EfetuarPagamento(100, DateTime.Now, "Tanque abastecido com Gás");
gas.ExecutarAcrescimo();
Console.WriteLine(gas.ObterHistoricodeAbastecimentos());