class Program
{
    public static void Main(string[] args)
    {

        var aulaIntro = new Aula("Aula Intro", 20);
        var aulaGestao = new Aula("Aula Gestao", 10);
        var aulaDataSciece = new Aula("Aula Data Science", 40);

        List<Aula> aulas = new List<Aula>();
        aulas.Add(aulaIntro);
        aulas.Add(aulaGestao);
        aulas.Add(aulaDataSciece);


        aulas.Sort();
        imprimir(aulas);

    }

    private static void imprimir(List<Aula> aulas)
    {
        Console.Clear();
        foreach (var aula in aulas)
        {
            Console.WriteLine(aula);
        }
    }

    class Aula : IComparable
    {


        public string titulo { get; set; }
        public int tempo { get; set; }

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public override string ToString()
        {
            return $"[título:{titulo} , tempo:{tempo} minutos]";
        }

        public int CompareTo(object? obj)
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(that.titulo);
        }
    }

}