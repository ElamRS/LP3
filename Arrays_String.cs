String aulaIntro = "Introdução às Coleções";
String aulaModelando = "Modelando a Classe Aula";
String aulaSets = "Trabalhando com Conjuntos";

string[] aulas = new string[3];
aulas[0] = aulaIntro;
aulas[1] = aulaModelando;
aulas[2] = aulaSets;

foreach (var aula in aulas) {
    Console.WriteLine(aula);
}
