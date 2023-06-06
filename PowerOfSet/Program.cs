class Program
{
    static void Main(string[] args)
    {
        ISet<string> alunos = new HashSet<string>();
        alunos.Add("Vanessa");
        alunos.Add("Ana");
        alunos.Add("Rafael");


        Console.WriteLine(alunos);
        Console.WriteLine(string.Join(",", alunos));

        //


        alunos.Add("Priscila");
        alunos.Add("Guilherme");
        alunos.Add("Rafael Rolo");
        Console.WriteLine(string.Join(",", alunos));


        //ordenação
        alunos.Remove("Ana");
        alunos.Add("Junior");
        Console.WriteLine(string.Join(",", alunos));

        //adicionando duplicidade
        alunos.Add("Junior");
        Console.WriteLine(string.Join(",", alunos));


        //Hashset: mais desempenho, consome mais memoria

        //List: escalabilidade, consome menos memoria


    }
}