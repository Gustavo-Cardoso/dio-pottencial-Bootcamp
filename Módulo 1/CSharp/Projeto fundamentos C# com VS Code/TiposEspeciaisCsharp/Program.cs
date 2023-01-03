using TiposEspeciaisCsharp.Models;
using Newtonsoft.Json;

// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail.");
// } 
// else 
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
// }

/*------------------------------------------------------*/

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("d/MM/yyyy HH:mm")}, {(venda.Desconto.HasValue ? $"Desconto de : {venda.Desconto}" : "")}");
// }

/*------------------------------------------------------*/

// var tipoAnonimo = new {Nome = "Gustavo", Sobrenome = "Cardoso", Altura = 1.77};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);

/*------------------------------------------------------*/

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonimo = listaVenda.Select(x => new {x.Produto, x.Preco});

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}