using ProjetoHospitalClassAtributos;

namespace ProjetoHospitalClassMetodos;

public class MetodosGerenciamentoPacientes
{
    public List<Paciente> listaDePaciente = new List<Paciente>();

    //METODO DE REGISTRO DE PACIENTE
    public void RegistrarPaciente(){
        Console.WriteLine("----CADASTRO DE PACIENTE----");
        
        digitarNomeNovamente:
        Console.WriteLine("Nome paciente:");
        string NomePaciente = Console.ReadLine();
        if(NomePaciente == ""){
            Console.WriteLine("O NOME É OBRIGATÓRIO");
            goto digitarNomeNovamente;
        }

        digitarIdadeNovamente:
        Console.WriteLine("Idade:");
        byte idadeDoPaciente = Convert.ToByte(Console.ReadLine());
        if(idadeDoPaciente <= 0){
            Console.WriteLine("A IDADE É OBRIGATÓRIA!");
            goto digitarIdadeNovamente;
        }

        Console.WriteLine("Genero: ");
        string GeneroPaciente = Console.ReadLine();


        Paciente paciente = new Paciente(NomePaciente,idadeDoPaciente,GeneroPaciente);

        listaDePaciente.Add(paciente);

        Console.WriteLine("---------------------------");
    }

    //METODO DE LISTAR PACIENTES
    public void ListarPacientesCadastrados(){
        Console.WriteLine("---LISTA DE PACIENTES---");
        foreach(var dadosPaciente in listaDePaciente){
            Console.WriteLine($"ID:{dadosPaciente.Id} NOME:{dadosPaciente.Nome} IDADE{dadosPaciente.Idade} GENERO{dadosPaciente.Genero}");
        }
        Console.WriteLine("-----------------------");
    }


    //METODO DE BUSCAR POR PACIENTE
    public void FazerProcuraPaciente(){
        Console.WriteLine("NOME PACIENTE:");
        string nomePacienteProcurado = Console.ReadLine();

        Paciente procurarPorPaciente = listaDePaciente.FirstOrDefault(paciente => paciente.Nome == nomePacienteProcurado);

        if(procurarPorPaciente != null){
            Console.WriteLine("!--PACIENTE ENCONTRADO--!");
            Console.WriteLine($"Id: {procurarPorPaciente.Id} Nome:{procurarPorPaciente.Nome} Idade:{procurarPorPaciente.Idade} Genero:{procurarPorPaciente.Genero}");
            Console.WriteLine("- - - - - - - - - - - - -");
        }else{
            Console.WriteLine("!--PACIENTE NÃO ENCONTRADO--!");
        }


    }

}
