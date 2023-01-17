using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public abstract class Conta // A palavra "ABSTRACT" ela significa aqui que essa classe não poderá ser instanciada diretamente. Ela pode ser somente herdada.
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor); // Método abstrato. A classe que herdar essa classe, terá que implementar esse método.

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + saldo);
        }
    }
}