using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Criando uma lista de inteiros
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

        // Solicitando um valor de entrada ao usuário
        Console.Write("Digite um número: ");
        int valorEntrada = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(valorEntrada);


        // Utilizando a cláusula "where" do LINQ para filtrar os números maiores que o valor de entrada
        var numerosFiltrados = numeros.Where(numero => numero > valorEntrada);

        // Exibindo os números filtrados
        Console.WriteLine("Números maiores que {0}:", valorEntrada);
        foreach (int numero in numerosFiltrados)
        {
            Console.WriteLine(numero);
        }


        List<string> nomes = new List<string> { "Ana", "Maria", "Joao" };
        Console.WriteLine("Digite um nome: ");
        string nomeDigitado = Console.ReadLine();
        Console.WriteLine("nomeDigitado: " + nomeDigitado);

        var retorno = nomes.Where(nome => nome == nomeDigitado);
        Console.WriteLine("retorno: " + retorno.ToString());


    }
}
