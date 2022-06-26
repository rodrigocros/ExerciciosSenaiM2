namespace FormularioInscricao;

public class CobrarCurso
{   
    private int ValorCurso;
    private int ValorMulta;
    private int ValorDesconto;
    private int Resultado;

    public CobrarCurso(int valorCurso, int valorMulta, int valorDesconto)
    {
        this.ValorCurso = valorCurso;
        this.ValorMulta = valorMulta;
        this.ValorDesconto = valorDesconto;
        this.Resultado = this.CalcularValorCurso(valorCurso, valorMulta, valorDesconto);
    }

    private int CalcularValorCurso(int valorCurso, int valorMulta, int valorDesconto)
    {
        if(this.ValorMulta > 0)
        {
            return  this.ValorCurso + this.ValorMulta;
        }
        else
        {
            return  this.ValorCurso - this.ValorDesconto;
        }
    }

}