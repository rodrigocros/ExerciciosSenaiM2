namespace rh;

public class Secretaria : SalarioEmpregado
{
    public int qtdAnosEmpresa { get; set; }

    public Secretaria(int id, string nome, double valorSalario, int cadigoFuncionando, int qtdAnosEmpresa) : base(id, nome, valorSalario, cadigoFuncionando)
    {
        this.qtdAnosEmpresa = qtdAnosEmpresa;
    }
}