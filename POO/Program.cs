using POO.Models;
using POO.Interfaces;

/* Abstração */
// Pessoa p1 = new Pessoa();

// p1.Nome = "Gustavo";
// p1.Idade = 23;

// p1.Apresentar();


/* Encapsulamento */
// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();


/* Herança */
// Aluno a1 = new Aluno();
// a1.Nome = "Gustavo";
// a1.Idade = 23;
// a1.Email = "teste@teste.com";
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Marcelo";
// p1.Idade = 45;
// p1.Salario = 2056.00M;
// p1.Apresentar();

/* Usando classe abstrata na prática */
// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();

/* Construtor por herança */
// Pessoa p = new Pessoa("Gustavo");
// Aluno a = new Aluno("Lucas");

// a.Apresentar();

/* Classe OBJECT na prática */
// Computador c = new Computador();
// Console.WriteLine(c.ToString());

/* Interface na prática */
ICalculadora calc = new Calculadora();

Console.WriteLine(calc.Somar(9, 3));
Console.WriteLine(calc.Subtrair(9, 3));
Console.WriteLine(calc.Multiplicar(9, 3));
Console.WriteLine(calc.Dividir(9, 3));