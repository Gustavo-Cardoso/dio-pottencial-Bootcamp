using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadeMetodoConstrutor.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int RetornarQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}:");            

            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }

            for (int i = 0; i < Alunos.Count; i++)
            {
                // Concatenação
                //string texto = "N° " + i + " - " + Alunos[i].NomeCompleto;

                // Interpolação
                string texto = $"N° {i} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}