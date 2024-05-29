using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospitalClassAtributos
{
    public class Consulta
    {
        private int id;
        private string data;
        private string hora;
        private string descricao;

        public int Id{get;set;}
        public string Data{get;set;}
        public string Hora{get;set;}
        public string Descricao{get;set;}
        
        public Paciente Paciente;

        public Medico Medico;


    }
}