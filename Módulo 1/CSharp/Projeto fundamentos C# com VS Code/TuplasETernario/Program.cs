using TuplasETernario.Models;
using System.Globalization;

// Tupla
// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Gustavo", "Cardoso", 1.75M);// Essa aqui é a mais recomendada

// Outras maneiras de usar a Tupla
//Fazendo de uma dessas maneiras não é possível nomear meu objeto
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Gustavo", "Cardoso", 1.75M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Gustavo", "Cardoso", 1.75M);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}m");

// Usando uma tupla em um método
// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); // O underline "_" nesse caso significa "DESCARTAR" uma infomração, ou seja não será utilizada
//var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); 

// if(sucesso)
// {
// Console.WriteLine("Quantidade linhas do meu arquivo: " + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("não foi porssível ler o arquivo");
// }

// Desconstrutor - Apenas separa. Exemplo: Um método com Nome e Sobrenome, é possível separar cada um deles em variáveis diferentes

// Pessoa p1 = new Pessoa("Gustavo", "Cardoso");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} + {sobrenome}");

// Vendo se um número é ímpar

int numero = 15;
bool ehPar = false;

// IF comum

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else 
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }

// Usando IF Ternário para ver se um número é ímpar

ehPar = numero % 2 == 0;
Console.WriteLine($"O númeor {numero} é:" + (ehPar ? "Par" : "Ímpar"));
