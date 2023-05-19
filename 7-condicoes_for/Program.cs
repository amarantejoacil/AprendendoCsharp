using System;

class Program
{
    static void Main(string[] args)
    {

        //for tradicional
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        //for tradicional
        int[] numeros = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("percorrendo e lendo array: " + numeros[i]);
        }

        //foeach
        int[] idades = { 18, 24, 67, 32 };
        foreach (int i in idades)
        {
            Console.WriteLine("imprimindo foeach: " + i);
        }

        string[] cars = { "volvo", "bmw", "ford", "mazda" };
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }


    }



}