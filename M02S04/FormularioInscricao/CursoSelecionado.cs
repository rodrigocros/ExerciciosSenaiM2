namespace FormularioInscricao;

internal class CursoSelecionado
{
    public IList<string> Cursos { get; set; }

    public CursoSelecionado()
    {
        this.Cursos = new List<string>();
        this.Cursos.Add("C#");
        this.Cursos.Add("Java");
        this.Cursos.Add("Python");
        this.Cursos.Add("Ruby");
        this.Cursos.Add("PHP");
        this.Cursos.Add("C++");
        this.Cursos.Add("Cobol");
        this.Cursos.Add("Visual Basic");
} 