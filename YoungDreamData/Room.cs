using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungDreamData
{
    internal class Room
    {
        public string Nome {  get; set; }
        public string Sexo { get; set; }
        public string Endereço { get; set; }
        public string NomePais { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public double Telefone { get; set; }
        public int Sala { get; set; }

        public override string ToString()
        {
            return $"Sala 1. Aluno: {Nome}, {Sexo}, {Idade} anos";
        }





    }
}
