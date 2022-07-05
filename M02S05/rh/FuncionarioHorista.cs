namespace rh;

public class FuncionarioHorista : Empregado
{
    public double taxa { get; set; }
    public string cnpj { get; set; }

    public FuncionarioHorista(int id, string nome, double taxa, string cnpj) : base(id, nome)
    {
        this.taxa = taxa;
        this.cnpj = cnpj;
    }

    public void CalcularTaxas()
    {
        System.Console.WriteLine("Calculando Taxas");
    }

    public void EmitirNotaFiscal()
    {
        System.Console.WriteLine("Emitindo Nota Fiscal");
    }

}