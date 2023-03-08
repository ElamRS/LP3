String aulaIntro = "Introdução às Coleções";
String aulaModelando = "Modelando a Classe Aula";
String aulaSets = "Trabalhando com Conjuntos";

string[] aulas = new string[3];
aulas[0] = aulaIntro;
aulas[1] = aulaModelando;
aulas[2] = aulaSets;

for (int i=0; i<aulas.Length; i++) {
    Console.WriteLine(aulas[i]);
}

Console.WriteLine("Aula modelando está no indíce " + Array.IndexOf(aulas, aulaModelando));
