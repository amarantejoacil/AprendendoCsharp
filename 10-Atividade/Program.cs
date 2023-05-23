


using _10_Atividade;

Pedido pedido1 = new Pedido();
pedido1.descricaoPedido = "X-File com bacon";
pedido1.valorPedido = 24.99;

Cliente novoCli = new Cliente();
novoCli.nome = "João";
novoCli.telefone = "65 99203-4321";
novoCli.endereco = "Rua X - Casa Y - Bairro H";
novoCli.pedido = pedido1;


Console.WriteLine("Dados do Cliente");
Console.WriteLine(novoCli.nome);
Console.WriteLine(novoCli.endereco);
Console.WriteLine(novoCli.telefone);
Console.WriteLine("");
Console.WriteLine("Dados do Pedido");
Console.WriteLine(novoCli.pedido.descricaoPedido);
Console.WriteLine(novoCli.pedido.valorPedido);






//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();



