using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Aluno : Pessoa
    {        
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");
        }
    }
}