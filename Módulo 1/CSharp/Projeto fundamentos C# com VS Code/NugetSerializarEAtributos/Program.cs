using NugetSerializarEAtributos.Models;
using System.Globalization;
using Newtonsoft.Json;

Venda v1 = new Venda(1, "Material de escritório", 25.00M);

//string serializado = JsonConvert.SerializeObject(v1); // Aqui o Json é em uma única linha
string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented); // Aqui fica com uma melhor visualização do Json, com as propriedades separadas por linha

Console.WriteLine(serializado);