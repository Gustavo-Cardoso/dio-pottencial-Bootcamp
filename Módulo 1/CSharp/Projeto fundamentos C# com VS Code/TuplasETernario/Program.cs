using System.Globalization;

(int, string, string, decimal) tupla = (1, "Gustavo", "Cardoso", 1.75M);

Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}m");

