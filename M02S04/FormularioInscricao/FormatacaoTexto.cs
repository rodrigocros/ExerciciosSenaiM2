namespace FormularioInscricao;

public static class FormatacaoTexto
{
    public static string Formatacao(string nome, string curso, int valorCurso)
    {
        return $"Nome: {nome}\nCurso: {curso}\nValor do curso: {valorCurso}\n";
    }
    public static string Formatacao(string nome, string curso, int valorCurso, int valorDesconto)
    {
        return $"Nome: {nome}\nCurso: {curso}\nValor do curso: {valorCurso}\nValor do desconto: {valorDesconto}\n";
    }
    public static string Formatacao(string nome, string curso, int valorCurso, int valorDesconto, int idade)
    {
        return $"Nome: {nome}\nCurso: {curso}\nValor do curso: {valorCurso}\nValor do desconto: {valorDesconto}\nIdade: {idade}\n";
    }

}


