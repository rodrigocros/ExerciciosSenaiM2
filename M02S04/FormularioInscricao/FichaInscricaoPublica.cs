namespace FormularioInscricao;

public class FichaInscricaoPublica
{
    public string Nome { get; set; }
    public int Idade { get;}
    public string Curso { get; set; }
    public string Escolaridade { get; set; }
    public string DataDeNascimento { get; set; }
    public int ValorCurso { get; set; }
    public int ValorDesconto { get; set; }
    public int ValorMulta { get; set; }

    public FichaInscricaoPublica(string nome, string curso, string escolaridade, string dataDeNascimento, int valorCurso, int valorDesconto, int valorMulta)
    {
        this.Nome = nome;
        this.Curso = curso;
        this.Escolaridade = escolaridade;
        this.DataDeNascimento = dataDeNascimento;
        this.ValorCurso = valorCurso;
        this.ValorDesconto = valorDesconto;
        this.ValorMulta = valorMulta;
        this.Idade = this.CalcularIdade();

    }

    private int CalcularIdade()
    {
        return DateTime.Now.Year - DateTime.Parse(this.DataDeNascimento).Year;
    }

}