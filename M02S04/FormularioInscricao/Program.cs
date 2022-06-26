namespace FormularioInscricao;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do aluno: ");
        var nome = Console.ReadLine();

        Console.WriteLine("Digite o curso do aluno: ");
        var curso = Console.ReadLine();

        Console.WriteLine("Digite a escolaridade do aluno: ");
        var escolaridade = Console.ReadLine();  

        Console.WriteLine("Digite a data de nascimento do aluno: ");
        var dataDeNascimento = Console.ReadLine();

        Console.WriteLine("Digite o valor do curso: ");
        var valorCurso = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o valor do desconto: ");
        var valorDesconto = int.Parse(Console.ReadLine()!);  

        Console.WriteLine("Digite o valor da multa: ");
        var valorMulta = int.Parse(Console.ReadLine()!);

        var ficha = new FichaInscricaoPublica(nome, curso, escolaridade, dataDeNascimento, valorCurso, valorDesconto, valorMulta);      


        if(ficha.ValorDesconto == 0)
        {
            Console.WriteLine(FormatacaoTexto.Formatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso));
        }
        else if(ficha.ValorDesconto > 0 && ficha.Idade < 18)
        {
            Console.WriteLine(FormatacaoTexto.Formatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso , ficha.ValorDesconto, ficha.Idade));
        }
        else if(ficha.ValorDesconto > 0)
        {
            Console.WriteLine(FormatacaoTexto.Formatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso , ficha.ValorDesconto));
        }

        Console.ReadLine();
    }
}