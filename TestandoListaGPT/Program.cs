

using System.Linq;

List<int> numeros = new List<int>();
numeros.Add(1);
numeros.Add(2);
numeros.Add(3);
numeros.Add(4);
numeros.Add(5);


List<string> nomes = new List<string>();
nomes.Add("Nome 01");
nomes.Add("Nome 02");
nomes.Add("Nome 03");
nomes.Add("Nome 04");
nomes.Add("Nome 05");


//Metodo Remove - Posso passa a posição ou o valor desejado.
nomes.Remove(nomes[0]);
nomes.Remove("Nome 02");


//Metodo Contains - Para numero
bool existe = numeros.Contains(1);
if (existe)
{
    Console.WriteLine("Existe");
}
else
{
    Console.WriteLine("Não existe");
}


//Count: Retorna o número de elementos na lista.
int quantidade = nomes.Count;
Console.WriteLine("Count: " + quantidade);


foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}



//Sort(): Classifica os elementos da lista em ordem crescente.
List<int> NumeroCrescente = new List<int>() { 10, 5, 2, 1, 7, 9, 4, 3, 6, 8 };
Console.WriteLine("------------Lista Desordenada------------");
foreach (var item in NumeroCrescente)
{
    Console.WriteLine(item);
}
NumeroCrescente.Sort();
Console.WriteLine("------------Lista Ordenada------------");
foreach (var item in NumeroCrescente)
{
    Console.WriteLine(item);
}

//Clear(): Remove todos os elementos da lista.

Console.WriteLine("---------------------numApartamento--------------------");
List<int> numApartamento = new List<int>() { 1, 2, 3, 4, 5 };
Console.WriteLine("-----------------SEM CLEAR---------------------");
foreach (var num in numApartamento)
{
    Console.WriteLine(num);
}



numApartamento.Clear();
Console.WriteLine("-----------------COM CLEAR---------------------");
foreach (var num in numApartamento)
{
    Console.WriteLine(num);
}
Console.WriteLine("numApartamento" + numApartamento);


Console.WriteLine("-----------------INDEX OFF---------------------");

//IndexOf(T item): Retorna o índice da primeira ocorrência de um elemento na lista.
List<string> texto = new List<string>() { "Maria", "Pedro", "Gustavo" };
int posicao = texto.IndexOf("Gustavo");
Console.WriteLine("posicao IndexOf: " + posicao.ToString());


Console.WriteLine("-----------------INSERT---------------------");
//Insert(int index, T item): Insere um elemento em um índice específico da lista.
List<int> numEscolasMT = new List<int>() { 1, 2, 3, 4, 5 };
Console.WriteLine("Lista antes da implementação =  1,2,3,4,5");

numEscolasMT.Insert(2, 10);
foreach (var num in numEscolasMT)
{
    Console.WriteLine("numEscolasMT: " + num.ToString());
}
