using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospitalClassAtributos
{
    public class Paciente : Pessoa
    {
        public Paciente( string nome, byte idade, string genero) : base( nome, idade, genero)
        {
        }
    }
}