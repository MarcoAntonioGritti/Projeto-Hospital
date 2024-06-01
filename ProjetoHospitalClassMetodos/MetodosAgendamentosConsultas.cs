using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHospitalClassAtributos;

namespace ProjetoHospitalClassMetodos
{
    public class MetodosAgendamentosConsultas
    {
        List<Consulta> listaDeConsulta = new List<Consulta>();        
        
        //METODO DE AGENDAMENTO DE CONSULTA
        public void AgendarConsulta(Paciente paciente, Medico medico){
            Console.WriteLine("---AGENDAR CONSULTA---");
            
            
            Console.WriteLine("DATA DA CONSULTA:");
            string dataDaConsulta = Console.ReadLine();

            //Tratamento de exceção caso o campo de data não for preenchido
            if(dataDaConsulta == " "){
                throw new Exception ("O campo de data não pode ser vazio!"); 
            }

            

            Console.WriteLine("HORA DA CONSULTA:");
            string HoraDaConsulta = Console.ReadLine();
            //Tratamento de exceção caso o campo de hora não for preenchido
            if(HoraDaConsulta == " "){
                throw new Exception ("O campo de hora não poder ser vazio."); 
            }

            
            //Instanciamento da class Consulta, onde esta passano seus valor pedidos pelo objeto
            Consulta consulta = new Consulta(dataDaConsulta,HoraDaConsulta,paciente,medico);

            //Passagem de tudo o que foi adicionado dentro do objeto acima, para dentro da lista consulta
            listaDeConsulta.Add(consulta);

            //Método onde voltara para o menu principal,dando outras opções de métodos
            MenuPrincipal();
        
        }

        public void ListarConsultas(){
            Console.WriteLine("---LISTA DE CONSULTA---");
            foreach(var lista in listaDeConsulta)
            {   
                Console.WriteLine($"ID{lista.Id} DATA:{lista.DataDaConsulta} HORA:{lista.HoraDaConsulta}" + 
                $"NOME PACIENTE:{lista.Paciente.Nome} NOME MÉDICO:{lista.Medico.Nome} ");
            }
            Console.WriteLine("----------------------");
            
            //Método onde voltara para o menu principal,dando outras opções de métodos
            MenuPrincipal();
        }

        public void BuscarConsulta(){
            Console.WriteLine("Digite o ID da sua consulta:");
            int idConsultaBuscada = Convert.ToInt32(Console.ReadLine());

            var Consultas = listaDeConsulta.FirstOrDefault(idConsulta => idConsulta.Id == idConsultaBuscada);
            if(Consultas != null){
                Console.WriteLine("---CONSULTA ENCONTRADA---");
                Console.WriteLine($"ID{Consultas.Id} DATA:{Consultas.DataDaConsulta} HORA:{Consultas.HoraDaConsulta}" + 
                $"NOME PACIENTE:{Consultas.Paciente.Nome} NOME MÉDICO:{Consultas.Medico.Nome} ");
                Console.WriteLine("-------------------------");
            }else{
                Console.WriteLine("!--CONSULTA NÃO ENCONTRADA--!");
            }

            //Método onde voltara para o menu principal,dando outras opções de métodos
            MenuPrincipal();
        }

        public void MenuPrincipal(){
            Console.WriteLine("1 - METODOS DO PACIENTE |");
            Console.WriteLine("2 - METODOS DO MÉDICO   |");
            Console.WriteLine("3 - AGENDAR CONSULTA    |");
            Console.WriteLine("4 - LISTAR CONSULTA     |");
            Console.WriteLine("5 - BUSCAR CONSULTA     |");

            string opcaoMenuPrincipal = Console.ReadLine();

            switch(opcaoMenuPrincipal){
                case "1":
                    MetodosGerenciamentoPacientes metodosDoPaciente = new MetodosGerenciamentoPacientes();
                    metodosDoPaciente.MenuDoPaciente();
                break;
                case "2":
                    MetodosGerenciamentoMedicos metodosDoCliente = new MetodosGerenciamentoMedicos();
                    metodosDoCliente.MenuDoPaciente();
                break;
                case "3":
                    
                break;
                case "4":
                break;
                case "5":
                break;
                default:
                    Console.WriteLine("ESTÁ OPÇÃO NÃO EXITE!");
                    MenuPrincipal();
                break;

            }
        }
    }
}