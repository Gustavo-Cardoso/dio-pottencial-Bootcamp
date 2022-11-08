using NugetSerializarEAtributos.Models;
using System.Globalization;
using Newtonsoft.Json;

// DateTime dataAtual = DateTime.Now; // Json usa como padrão no DateTime a iso 8601

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Caderno 10 matérias capa dura ", 18.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

//string serializado = JsonConvert.SerializeObject(v1); // Aqui o Json é em uma única linha
// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); // Aqui fica com uma melhor visualização do Json, com as propriedades separadas por linha

// File.WriteAllText("Arquivos/Vendas.json", serializado); // Crio um arquivo Json que recebe o conteúdo da variável serializado

// Console.WriteLine(serializado);

string conteudoArquivo = File.ReadAllText("Arquivos/Vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("d/MM/yyyy HH:mm")}");
}