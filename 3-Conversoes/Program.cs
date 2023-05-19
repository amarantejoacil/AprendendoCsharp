using System;


class Program
{
    static void Main(string[] args)
    {
        //Conversão implícita:
        int numeroInteiro = 10;
        double numeroDecimal = numeroInteiro;
        Console.WriteLine("convertendo inteiro em decimal: "+numeroDecimal);


        //Conversão explícita:
        double Ex2_numeroDecimal = 10.5;
        int Ex2_numeroInteiro = (int)Ex2_numeroDecimal; // Conversão explícita de double para int
        Console.WriteLine("convertendo decial em inteiro: "+Ex2_numeroInteiro);

        //Conversão de string para número:
        string numeroTexto = "25";
        int numero = int.Parse(numeroTexto);
        Console.WriteLine("convertendo texto para numero: " + numero);


        //Conversão de número para string:
        int numPagina = 25;
        string textoPagina = numPagina.ToString();
        Console.WriteLine("convertendo número para textoString: "+textoPagina);


        int i = 10;
        Console.WriteLine("Imprimindo tipo da variavel: "+i.GetType());
      

        //i = int.Parse(d.ToString());
        //i.GetType();
        //Console.WriteLine("i: "+i);

    }


}