// See https://aka.ms/new-console-template for more information
using estrutura_algoritimo.Estrutura;


Vetor vetor = new Vetor(10);

vetor.Adicionar("A");
vetor.Adicionar("B");
vetor.Adicionar("C");
vetor.Adicionar("D");
vetor.Adicionar("F");
vetor.Adicionar("G");
vetor.Adicionar("H");

Console.WriteLine(vetor.ToString());

vetor.Adicionar("E", 4);

Console.WriteLine(vetor.ToString());
