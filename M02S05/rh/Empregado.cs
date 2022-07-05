namespace rh;

public class Empregado
{
    public int id { get; set; }
    public string nome { get; set; }

    public Empregado(int id, string nome)
    {
        this.id = id;
        this.nome = nome;
    }

    public void trabalhar()
    {
        System.Console.WriteLine("Trabalhando");
    }
    public void IrEmbora()
    {
        System.Console.WriteLine("Ir para Casa");
    }
    public void TirarFolga()
    {
        System.Console.WriteLine("Não vim trabalhar");
    }

}