using System;

class Program
{
    enum DiaDaSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado };
  

    static void Main()
    {
        int idade = 25;
        float altura = 1.75f;
        double peso = 65.5;
        decimal salario = 2500.50m;
        char genero = 'M';
        bool temCarro = true;
        string nome = "João";
        DateTime dataNascimento = new DateTime(1990, 5, 10);
        int[] numeros = { 1, 2, 3, 4, 5 };
        List<string> nomes = new List<string>() { "Ana", "Carlos", "Maria" };
        object obj = new object();
        
        DiaDaSemana diaAtual = DiaDaSemana.Segunda;

        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Peso: " + peso);
        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Gênero: " + genero);
        Console.WriteLine("Tem carro? " + temCarro);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Data de Nascimento: " + dataNascimento.ToShortDateString());
        Console.WriteLine("Números: " + string.Join(", ", numeros));
        Console.WriteLine("Nomes: " + string.Join(", ", nomes));
        Console.WriteLine("Objeto: " + obj.ToString());
        Console.WriteLine("Dia atual: " + diaAtual);
    }
}
