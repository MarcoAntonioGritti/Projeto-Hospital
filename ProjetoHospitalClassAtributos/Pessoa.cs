namespace ProjetoHospitalClassAtributos;

public class Pessoa
{
    private int id = 1;
    private string nome;
    private byte idade;
    private string genero;

    public int Id{get;set;}
    public string Nome{get;set;}
    public byte Idade{get;set;}
    public string Genero{get;set;}

    public Pessoa(string nome,byte idade, string genero){
        Id = id++;
        Nome = nome;
        Idade = idade;
        Genero = genero;
    }


}
