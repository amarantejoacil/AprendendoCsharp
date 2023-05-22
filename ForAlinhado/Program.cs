using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        double fatorRendimento = 1.005;
        double salarioMinimo = 1.320;

        int count = 0;
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Contador-----------------------------------------------: " + count++);

            fatorRendimento = fatorRendimento + 0.001;
            Console.WriteLine(fatorRendimento.ToString());

            for (int mes = 1; mes <= 12; mes++)
            {
                Console.WriteLine("Mês: " + mes.ToString());
                salarioMinimo *= fatorRendimento;
                Console.WriteLine(salarioMinimo);
            }

        }

        int[] id = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string[] nomes = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
        for (int i = 0; i < id.Length; i++)
        {

            //Console.WriteLine(id[i]);
            //if (id[i] % 2 == 0)
            //{
            //    Console.WriteLine("esse número é PAR: " + id[i]);
            //} else
            //{
            //    Console.WriteLine("esse número é IMPAR: " + id[i]);
            //}
        }




    }
}