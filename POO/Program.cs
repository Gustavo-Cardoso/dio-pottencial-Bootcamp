using POO.Models;

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

Aluno a1 = new Aluno();
a1.Nome = "Gustavo";
a1.Idade = 23;
a1.Email = "teste@teste.com";
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Gustavo";
p1.Idade = 23;
p1.Salario = 2056.00M;
p1.Apresentar();