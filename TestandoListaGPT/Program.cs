

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


Console.WriteLine("-----------------Exists---------------------");

List<string> sobreNomes = new List<string>();
sobreNomes.Add("Nome 01");
sobreNomes.Add("Nome 02");
sobreNomes.Add("Nome 03");

bool existeOuNao = sobreNomes.Exists(sobreNomes => sobreNomes == "Nome 012");
Console.WriteLine("existeOuNao: " + existeOuNao.ToString());


Console.WriteLine("-----------------FIND---------------------");
//Find(Predicate<T> match): Encontra o primeiro elemento que atende a uma determinada condição.

List<int> numerosApartamentos = new List<int> { 1, 2, 3, 7, 5 };

int primeiroMaiorQueTres = numerosApartamentos.Find(numero => numero > 3);
Console.WriteLine("numerosApartamentos: " + primeiroMaiorQueTres.ToString());
//7


Console.WriteLine("-----------------FINDLAST---------------------");
//FindLast(Predicate<T> match): Encontra o último elemento que atende a uma determinada condição.
List<int> numerosCasa = new List<int> { 1, 2, 3, 4, 5 };

int retornoCasa = numerosCasa.FindLast(retorno => retorno > 2);
Console.WriteLine("numerosCasa: " + retornoCasa.ToString());
//7


Console.WriteLine("-----------------FINDALL---------------------");
//FindAll(Predicate<T> match): Encontra todos os elementos que atendem a uma determinada condição.

List<int> numerosDeBlocos = new List<int> { 11, 22, 33, 44, 55 };

List<int> maioresQueTres = numerosDeBlocos.FindAll(numero => numero > 32);
foreach (int numero in maioresQueTres)
{
    Console.WriteLine("FINDALL: " + numero);
}




Console.WriteLine("-----------------FIND INDEX---------------------");
//FindIndex(Predicate<T> match): Encontra o índice do primeiro elemento que atende a uma determinada condição.


List<int> placaCarro = new List<int> { 1223, 2234, 3213, 4468, 51249 };

int indiceMaiorQueTres = placaCarro.FindIndex(numero => numero > 3353);
Console.WriteLine("FIND INDEX: " + indiceMaiorQueTres);
//resposta 3


Console.WriteLine("-----------------RETORNAR O ÚLTIMO INDEX---------------------");
//FindLastIndex(Predicate<T> match): Encontra o índice do último elemento que atende a uma determinada condição.

List<int> numerosDeComputadores = new List<int> { 1, 2, 3, 4, 5 };

int ultimoIndiceMaiorQueTres = numerosDeComputadores.FindLastIndex(numero => numero > 4);
Console.WriteLine("RETORNAR O ÚLTIMO INDEX: " + ultimoIndiceMaiorQueTres);


//numerosDeComputadores.Where

//resposta 3
// se retornar -1 , é pq não encontrou


{

}