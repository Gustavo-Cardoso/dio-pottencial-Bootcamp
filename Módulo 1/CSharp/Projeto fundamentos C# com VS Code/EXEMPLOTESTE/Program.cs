using ExemploTeste.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Gustavo";
pessoa1.Idade = 23;
pessoa1.Apresentar();

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);