using TiposEspeciaisCsharp.Models;
using Newtonsoft.Json;

/*--------------------- Nullable ---------------------------------*/

// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail.");
// } 
// else 
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
// }

/*---------------------Nullable em propriedades ---------------------------------*/

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("d/MM/yyyy HH:mm")}, {(venda.Desconto.HasValue ? $"Desconto de : {venda.Desconto}" : "")}");
// }

/*----------------------- Tipo Anônimo -------------------------------*/

// var tipoAnonimo = new {Nome = "Gustavo", Sobrenome = "Cardoso", Altura = 1.77};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);

/*-------------------------- Tipo Anônimo em coleção ----------------------------*/

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new {x.Produto, x.Preco});

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }

/*-------------------------- Tipo Dinâmico ----------------------------*/

// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor {variavelDinamica}");

// variavelDinamica = "texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor {variavelDinamica}");

/*-------------------------- Classe Genêrica ----------------------------*/

MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);



MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Teste");

Console.WriteLine(arrayString[0]);