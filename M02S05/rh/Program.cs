namespace rh;

public class Program
{
    public static void Main(string[] args)
    {
        Secretaria secretaria = new Secretaria(1, "João", 1000, 1, 10);
        secretaria.trabalhar();    
        secretaria.IrEmbora();
        secretaria.TirarFolga();
        secretaria.CalcularFolha();

    }
}