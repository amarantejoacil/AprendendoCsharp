class Program
{
    static void Main(string[] args)
    {

        string primeiroProduto = "Primeiro Produto";
        string segundoProduto = "Segundo Produto";
        string terceiroProduto = "Terceiro Produto";

        List<string> produtos = new List<string>() { primeiroProduto, segundoProduto, terceiroProduto };

        //para cada produto, execute o cod. dentro das chaves ou para atender faça determina expressão
        produtos.ForEach(produto => { Console.WriteLine(produto); });


        produtos[0] = "Novo primeiro produto";
        Console.WriteLine("----------------------------Imprimindo após alterar o primeiro index-----------------------------");
        produtos.ForEach(produto => { Console.WriteLine(produto); });


        Console.WriteLine("----------------------------Removendo a teceria posicao-----------------------------");

        produtos.RemoveAt(produtos.Count - 1);
        produtos.ForEach(produto => { Console.WriteLine(produto); });



        Console.WriteLine("----------------------------Adicionando novo produto -----------------------------");
        produtos.Add("Novo produto adicionado pelo Add");
        produtos.ForEach(produto => { Console.WriteLine(produto); });



        Console.WriteLine("count: " + produtos.Count);
        Console.WriteLine("----------------------------Copia da lista  produto -----------------------------");
        List<string> copiaListaDeProduto = produtos.GetRange(0, 1);
        copiaListaDeProduto.ForEach(novoProduto => { Console.WriteLine(novoProduto); });


        Console.WriteLine("----------------------------Clonar da lista  produto -----------------------------");
        List<string> Clone = new List<string>(produtos);
        foreach (var c in Clone)
        {
            Console.WriteLine(c);
        }

        Console.WriteLine("----------------------------Removendo com range-----------------------------");
        Clone.RemoveRange(0, 2);
        Clone.ForEach(c => Console.WriteLine(c));

    }
}