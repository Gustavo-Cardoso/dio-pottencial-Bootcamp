
// int numero = 0;

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} X {i} = {numero*i}");
// }

// -----------------------------------------------------------------
// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero*contador}");
//     contador++;
// }

// -----------------------------------------------------------------

int soma = 0;
int numero = 0;

do 
{
    Console.WriteLine("Digite um número: (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma+=numero;

} while(numero != 0);

Console.WriteLine($"Total números digitados: {soma}");

// -----------------------------------------------------------------
// int numero = 0;
// int numeroMax = 0;

// Console.WriteLine("Informe um número para calcular sua tabuada:");
// numero = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Informe o número limite:");
// numeroMax = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i <= numeroMax; i++)
// {
//     Console.WriteLine($"{numero} X {i} = {numero*i}");
// }





