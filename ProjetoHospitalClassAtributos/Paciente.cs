using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospitalClassAtributos
{
    public class Paciente : Pessoa
    {
        public Paciente(byte id, string nome, byte idade, string genero) : base(id, nome, idade, genero)
        {
        }
    }
}