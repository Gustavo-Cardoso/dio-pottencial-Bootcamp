using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public /*sealed*/ class Professor : Pessoa // Sealed tem como objetivo impedir que seja feito a herança dessa classe
    {
        public Professor()
        {
            
        }

        public Professor(string nome) : base(nome)
        {
            
        }

        public decimal Salario { get; set; }

        public /*sealed*/ override void Apresentar() // Sealed tem como objetivo impedir que seja feito a herança dessa classe
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganha {Salario}");
        }
    }
}