using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospitalClassAtributos
{
    public class Consulta
    {
        private int id = 1;
        private string dataDaConsulta;
        private string horaDaConsulta;

        public int Id{get;set;}
        public string DataDaConsulta{get;set;}
        public string HoraDaConsulta{get;set;}

         public Paciente Paciente;
         public Medico Medico;
        

        public Consulta (string data,string hora,Paciente paciente,Medico medico){
            Id++;
            DataDaConsulta = data;
            HoraDaConsulta = hora;
            Paciente = paciente;
            Medico = medico;
        }

    }
}