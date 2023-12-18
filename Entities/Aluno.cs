using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumoApi_Aluno.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Situacao { get; set; }
        public int Matricula { get; set; }

        public bool Verifica = false;
    }

    
}