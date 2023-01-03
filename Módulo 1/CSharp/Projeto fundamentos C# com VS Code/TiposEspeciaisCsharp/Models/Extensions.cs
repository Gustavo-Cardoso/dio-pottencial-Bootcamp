using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiposEspeciaisCsharp.Models
{
    public static class Extensions
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}