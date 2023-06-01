using bytebank_GeradorChavePix;
using System;
class Programa
{
    static void Main(System.String[] args)
    {
        string chave = GeradorPix.GetChavePix();
        Console.WriteLine(chave);
    }
}