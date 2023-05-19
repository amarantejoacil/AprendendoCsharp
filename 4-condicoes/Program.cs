using System;

class Program
{


    static void Main(string[] args)
    {
        //teste 1
        int numero = 15;
        if (numero > 10)
        {
            Console.WriteLine("entrou no if");

        }

        /*teste 02*/
        int teste_dois = -5;
        if (teste_dois > 0)
        {
            Console.WriteLine("O número é positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é negativo");
        }
        else
        {
            Console.WriteLine("O número é zero");
        }


        //test || e &&
        int idade = 17;
        bool estaAcompanhado = false;
        bool autorizacaoEspecial = true;

        if (idade >= 18 && estaAcompanhado)
        {
            Console.WriteLine("usuário permitido");
        }
        else if (idade == 18 && autorizacaoEspecial)
        {
            Console.WriteLine("usuário negado");
        }
        else
        {
            Console.WriteLine("executou o else");
        }



    }
}