using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHospitalClassAtributos;

namespace ProjetoHospitalClassMetodos
{
    public class MetodosGerenciamentoMedicos
    {
        List<Medico> listaDeMedicos = new List<Medico>();

        //METODO DE REGISTRO DE MEDICO
    public void RegistrarMedico(){
        Console.WriteLine("----CADASTRO DE PACIENTE----");
        
        digitarNomeNovamente:
        Console.WriteLine("Nome médico:");
        string NomeMedico = Console.ReadLine();
        if(NomeMedico == ""){
            Console.WriteLine("O NOME É OBRIGATÓRIO");
            goto digitarNomeNovamente;
        }

        digitarIdadeNovamente:
        Console.WriteLine("Idade:");
        byte idadeDoMedico = Convert.ToByte(Console.ReadLine());
        if(idadeDoMedico <= 0){
            Console.WriteLine("A IDADE É OBRIGATÓRIA!");
            goto digitarIdadeNovamente;
        }

        Console.WriteLine("Genero: ");
        string GeneroMedico = Console.ReadLine();


        Medico medico = new Medico(NomeMedico,idadeDoMedico,GeneroMedico);

        listaDeMedicos.Add(medico);

        Console.WriteLine("---------------------------");
    }

        //METODO DE LISTAR MEDICO
         public void ListarMedicosCadastrados(){
        Console.WriteLine("---LISTA DE MÉDICOS---");
        foreach(var dadosMedicos in listaDeMedicos){
            Console.WriteLine($"ID:{dadosMedicos.Id} NOME:{dadosMedicos.Nome} IDADE{dadosMedicos.Idade} GENERO{dadosMedicos.Genero}");
        }
        Console.WriteLine("-----------------------");
    }
        //METODO DE BUSCAR POR MEDICO

        public void FazerProcuraMedico(){
            Console.WriteLine("NOME MÉDICO:");
            string nomeMedicoProcurado = Console.ReadLine();

            var procurarPorMedico = listaDeMedicos.FirstOrDefault(medico => medico.Nome == nomeMedicoProcurado);

            if(procurarPorMedico != null){
                Console.WriteLine("!--MÉDICO ENCONTRADO--!");
                Console.WriteLine($"Id: {procurarPorMedico.Id} Nome:{procurarPorMedico.Nome} Idade:{procurarPorMedico.Idade} Genero:{procurarPorMedico.Genero}");
                Console.WriteLine("- - - - - - - - - - - - -");
            }else{
                Console.WriteLine("!--MÉDICO NÃO ENCONTRADO--!");
            }
        }

        public void MenuDoPaciente(){
            
        }

    }
}