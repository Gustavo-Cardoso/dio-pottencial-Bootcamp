using BootcampDio.Common.Models;

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Gustavo";
// pessoa1.Idade = 23;
// pessoa1.Apresentar();

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);



// Criando Array
// Percorrendo Array com o FOR

// int[] arrayInteriros = new int[3];

// arrayInteriros[0]= 7;
// arrayInteriros[1]= 15;
// arrayInteriros[2]= 23;

// for (int i = 0; i < arrayInteriros.Length; i++)
// {
//     Console.WriteLine($"Posição N°: {i} - {arrayInteriros[i]}");
// }

// Criando FOREACH
// Percorrendo Array com o FOREACH

// int iForeach = 0;
// foreach(int valor in arrayInteriros)
// {
//     Console.WriteLine($"Posição N° {iForeach} - {valor}");
//     iForeach++;
// }

// Redimensionando um Array

// int[] arrayInteriros = new int[3];
// 
// arrayInteriros[0]= 7;
// arrayInteriros[1]= 15;
// arrayInteriros[2]= 23;

// Usando um método da classe Array
// Array.Resize(ref arrayInteriros, arrayInteriros.Length * 2);
// Fazendo um "Resize" manual

// int[] arrayInteiroDobrado = new int[arrayInteriros.Length * 2];
// Array.Copy(arrayInteriros, arrayInteiroDobrado, arrayInteriros.Length);

// for (int i = 0; i < arrayInteriros.Length; i++)
// {
//     Console.WriteLine($"Posição N°: {i} - {arrayInteriros[i]}");
// }

// Criando uma lista

List<string> listaString = new List<string>();

listaString.Add("Jan");
listaString.Add("Fev");
listaString.Add("Mar");
listaString.Add("Abr");
listaString.Add("Mai");
listaString.Add("Jun");
listaString.Add("Jul");
listaString.Add("Ago");
listaString.Add("Set");

// for (int i = 0; i < listaString.Count; i++)
// {
//     Console.WriteLine($"Posição N° {i} - {listaString[i]}");
// }

int iForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição N° {iForeach} - {item}");
    iForeach++;
}