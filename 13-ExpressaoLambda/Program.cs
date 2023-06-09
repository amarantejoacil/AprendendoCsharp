﻿



//criando lista e percorrendo
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


//percorrendo normal
//for (int i = 0; i < numeros.Count; i++)
//{
//    Console.WriteLine(numeros[i]);
//}


List<int> numeroPares = numeros.FindAll(BuscaNumerosPares);

bool BuscaNumerosPares(int numero)
{
    return numero % 2 == 0;
}

//BuscaNumerosPares(3);

foreach (int numero in numeroPares)
{
    Console.WriteLine(numero);
}


//-------------------------------LAMBADA----------------------------

Console.WriteLine("-------------------------------LAMBADA----------------------------");
List<int> numeroExLambda = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
List<int> numParesLambda = numeroExLambda.FindAll(num => num % 2 == 0);

numParesLambda.ForEach(numero => Console.WriteLine(numero));

