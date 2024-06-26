﻿// See https://aka.ms/new-console-template for more information
using estrutura_algoritimo.Estrutura;
using estrutura_algoritimo.Model;
using System.Collections;


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

Console.WriteLine("Testar Remove");

Console.WriteLine("Remove posição: 2 = C");
vetor.removeAt(2);

Console.WriteLine("VETOR apos remoção posição: 2 = C");
Console.WriteLine(vetor.ToString());

Console.WriteLine("Remove elemento F");
vetor.remove("F");

Console.WriteLine("VETOR apos remoção F");
Console.WriteLine(vetor.ToString());

Contato c1 = new Contato();
c1.Nome = "Felipe";
c1.Email = "felipe@felix.com";
c1.Telefone = "123-4560";

Contato c2 = new Contato();
c2.Nome = "Joice";
c2.Email = "joice@felix.com";
c2.Telefone = "123-9860";

Contato c3 = new Contato();
c3.Nome = "Joice";
c3.Email = "joice@felix.com";
c3.Telefone = "123-9860";

VetorObejct vetorO = new VetorObejct(10);

vetorO.Adicionar(c1);
vetorO.Adicionar(c2);
vetorO.Adicionar(c3);

Console.WriteLine("Imprime Vetor:");
Console.WriteLine(vetorO.ToString());


Console.WriteLine("Comparando valor do vetor com valor add, são iguais");
Console.WriteLine(vetorO.GetByIndex(1).Equals(c2));

Console.WriteLine("Classe Nativa List C#");

List<String> arrayList = new List<String>(5);
arrayList.Add("A");
arrayList.Add("B");
arrayList.Add("E");

Console.WriteLine(string.Join(", ", arrayList));

arrayList.Insert(2, "C");

Console.WriteLine(string.Join(", ", arrayList));

string element = "A";
Console.WriteLine(element);
Console.WriteLine(string.Concat(element, arrayList.IndexOf(element)));
if (arrayList.Contains(element))
{
    Console.WriteLine(string.Concat("element exist in Array: ", element));
}
else {
    Console.WriteLine(string.Concat("element doen´t exist in Array: ", element));
}

string element1 = "G";
Console.WriteLine(element1);
Console.WriteLine(string.Concat(element1, arrayList.IndexOf(element1)));
if (arrayList.Contains(element))
{
    Console.WriteLine(string.Concat("element exist in Array: ", element1));
}
else
{
    Console.WriteLine(string.Concat("element doen´t exist in Array: ", element1));
}

arrayList.Remove("A");
arrayList.Remove("C");
Console.WriteLine(string.Join(", ", arrayList));
Console.WriteLine(arrayList.Count);


