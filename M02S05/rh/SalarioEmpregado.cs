namespace rh;

public class SalarioEmpregado : Empregado
{
    public double valorSalario { get; set; }
    public int cadigoFuncionando { get; set; }

    public SalarioEmpregado(int id, string nome, double valorSalario, int cadigoFuncionando) : base(id, nome)
    {
        this.valorSalario = valorSalario;
        this.cadigoFuncionando = cadigoFuncionando;
    }
    public void CalcularFolha()
    {
        System.Console.WriteLine("Calculando Folha");
    }
}