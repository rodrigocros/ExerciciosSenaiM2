namespace MasterCard;

public class Program
{
    public static void Main(string[] args)
    {
        CartaoVR cartaoVR = new CartaoVR("Visa", 1000, 2);
        cartaoVR.VerificarValorTaxaCartao();
        CartaoVA cartaoVA = new CartaoVA("Nubank", 52000, 2);
        cartaoVA.VerificarValorTaxaCartao();
        CartaoVT cartaoVT = new CartaoVT("MasterCard", 5000, 2);
        cartaoVT.VerificarValorTaxaCartao();

        Cartao cartao = new CartaoVR("Visa", 1000, 2);
        cartao.VerificarValorTaxaCartao();
    }
}