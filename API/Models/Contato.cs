using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Contato
    {   
        public int Id { get; set; }
        public string Nome { get; set; }
        public string telefone { get; set; }
        public bool Ativo { get; set; }
    }
}