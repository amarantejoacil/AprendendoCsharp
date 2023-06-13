
using ListReadyOnly;
using SetNoModelos;

class Program
{
    static void Main(string[] args)
    {

        Curso csharpColecoes = new Curso("C# colecoes", "Marcelo oliveira");
        csharpColecoes.Adiciona(new Aula("Trabalhando com lista", 29));
        csharpColecoes.Adiciona(new Aula("Trabalhando com Metodos", 21));
        csharpColecoes.Adiciona(new Aula("Trabalhando com Arrays", 16));


        //instancia aluno
        Aluno a1 = new Aluno("Vanessa", 1);
        Aluno a2 = new Aluno("Ana", 2);
        Aluno a3 = new Aluno("Rafael", 3);


        //matricular aluno
        csharpColecoes.matricula(a1);
        csharpColecoes.matricula(a2);
        csharpColecoes.matricula(a3);

        Console.WriteLine("Alunos matriculados");
        foreach (var aluno in csharpColecoes.Alunos)
        {
            Console.WriteLine(aluno);
        }

        Console.WriteLine($"O aluno a1: {a1.Nome}, está matriculado?");
        Console.WriteLine("Verificando se está matriculado: " + csharpColecoes.EstraMatriculado(a1));

        Aluno joacil = new Aluno("Joacil", 4);
        Console.WriteLine("Aluno: Joacil, está matriulado? " + csharpColecoes.EstraMatriculado(joacil));


        Console.WriteLine(a1 == joacil);
        Console.WriteLine(a1.Equals(joacil));


        Console.WriteLine("Quem é o aluno com a matricula: 3 ? ");
        Aluno alunoBusca = csharpColecoes.buscaMatriculado(3);
        Aluno alunoBuscaDicionario = csharpColecoes.buscaMatriculadoDicionario(3);
        Console.WriteLine("alunoBusca: " + alunoBusca);
        Console.WriteLine("alunoBuscaDicionario: " + alunoBuscaDicionario);

        //adicionando aluno repitido com dicionario... estoura erro, para isso precisamos implementar um metodo de substituir aluno
        Aluno fabio = new Aluno("Fabio", 3);
        csharpColecoes.substituiAluno(fabio);
        Console.WriteLine("Quem é o aluno do cod: 3 ?" + csharpColecoes.buscaMatriculadoDicionario(3));



    }
}