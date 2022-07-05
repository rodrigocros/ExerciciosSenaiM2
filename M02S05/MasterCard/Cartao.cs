namespace MasterCard;


public class Cartao
{
    public string Bandeira { get; set; }
    public double Saldo { get; set; }
    public double ValorTaxa { get; set; }

    public Cartao(string bandeira, double saldo, double valorTaxa)
    {
        Bandeira = bandeira;
        Saldo = saldo;
        ValorTaxa = valorTaxa;
    }

    public void VerificarValorTaxaCartao()
    {
        double ValorTotalTaxa = Saldo * (ValorTaxa/100);
        Console.WriteLine("Valor da taxa: " + ValorTotalTaxa);
    }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }
}

