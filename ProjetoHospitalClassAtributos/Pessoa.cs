namespace ProjetoHospitalClassAtributos;

public class Pessoa
{
    private byte id;
    private string nome;
    private byte idade;
    private string genero;

    public byte Id{get;set;}
    public string Nome{get;set;}
    public byte Idade{get;set;}
    public string Genero{get;set;}

    public Pessoa(byte id,string nome,byte idade, string genero){
        Id = id;
        Nome = nome;
        Idade = idade;
        Genero = genero;
    }


}
