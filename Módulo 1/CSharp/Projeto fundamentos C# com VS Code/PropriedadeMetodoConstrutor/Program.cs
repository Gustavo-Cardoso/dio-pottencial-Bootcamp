using PropriedadeMetodoConstrutor.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Gustavo";
// p1.Sobrenome = "Cardoso";

// Pessoa p2 = new Pessoa();
// p2.Nome = "Débora";
// p2.Sobrenome = "Lopes";

// Usando os contrutores
Pessoa p1 = new Pessoa(nome: "Gustavo", sobrenome: "Cardoso"); // Explicito
Pessoa p2 = new Pessoa("Débora", "Lopes"); // Implícito

Curso curso = new Curso();
curso.Nome = "Inglês";
curso.Alunos = new List<Pessoa>();

curso.AdicionarAluno(p1);
curso.AdicionarAluno(p2);
curso.ListarAlunos();