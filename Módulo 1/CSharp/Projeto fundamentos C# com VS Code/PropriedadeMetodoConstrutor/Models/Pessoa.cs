using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadeMetodoConstrutor.Models
{
    public class Pessoa
    {
        // Construtor
        // Posso ter quantos construtores eu precisar

        // Padrão 
        public Pessoa()
        {

        }

        // Receberá os parâmetros quando preechido
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome 
        {
            // get
            // {
            //     return _nome.ToUpper();
            // }

            //Body Expressions
            // Quando for verificações simples posso fazer assim!
            get => _nome.ToUpper();

            set
            {
                // Verificando se o nome é vazio
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome{ get; set; }

        public int Idade 
        {
            get => _idade;

            set
            {
                // Verificando se idade é menor que zero
                if(value < 0)
                {
                    throw new ArgumentException("Idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}. Idade: {Idade}");
        }
    }
}