using ExcecoesEColecoes.Models;

// Realizando a leitura de um arquivo

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }
// // Posso ter quantos "catch" eu precisar
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// // O "finally" sempre será utilizado com ou sem erro. Ele pode fechar conexão do banco para não ficar com ela aberta consumindo memória
// }finally
// {
//     Console.WriteLine("Chegou até aqui!");
// }

// Usando o Throw
// new ExemploExcecao().Metodo1();

// Usando FILA (FIFO -> First IN, First OUT -> Primeiro a entrar, primeiro a sair)

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Sempre irá remover o primeiro elemento que entrou na fila
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Usando Pilha (Last IN, Fist OUT -> Último a entrar, primeiro a sair)

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

// Sempre irá remover o último elemento que entrou na pilha 
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(20);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}