// Realizando a leitura de um arquivo

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
// Posso ter quantos "catch" eu precisar
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado. {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// O "finally" sempre será utilizado com ou sem erro. Ele pode fechar conexão do banco para não ficar com ela aberta consumindo memória
}finally
{
    Console.WriteLine("Chegou até aqui!");
}