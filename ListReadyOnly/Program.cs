using ListReadyOnly;

class Program
{
    static void Main(string[] args)
    {
        Curso cshapColecoes = new Curso("C# Collection", "Marcelo Oliveira");
        cshapColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
        imprimir(cshapColecoes.Aulas);

        cshapColecoes.Adiciona(new Aula("Criando uma aula", 20));
        cshapColecoes.Adiciona(new Aula("Modelando com coleçoes", 19));
        imprimir(cshapColecoes.Aulas);

        //ordernar a lista de aulas
        //copiar a lista para outra lista

        List<Aula> aulaCopiadas = new List<Aula>(cshapColecoes.Aulas);

        //ordenando a copia
        aulaCopiadas.Sort();
        imprimir(aulaCopiadas);


        //totalizar tempo do curso
        Console.WriteLine(cshapColecoes.TempoTotal);


        //imprimir detalhes do curso
        Console.WriteLine(cshapColecoes);

    }

    private static void imprimir(IList<Aula> aulas)
    {
        Console.Clear();
        foreach (var aula in aulas)
        {
            Console.WriteLine(aula);
        }
    }
}