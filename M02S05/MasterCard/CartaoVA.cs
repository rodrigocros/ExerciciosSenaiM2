namespace MasterCard;


public class CartaoVA : Cartao
{
    public CartaoVA(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
    {
    }
    
    public override void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine("Depósito realizado com sucesso!");
    }

}