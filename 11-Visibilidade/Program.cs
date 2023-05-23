



using _11_Visibilidade;

Cliente cliente1 = new Cliente();
cliente1.nome = "Davi";


Cliente cliente2 = new Cliente();
cliente2.nome = "Maria";



Conta conta1 = new Conta();
conta1.agencia = "11111";
conta1.DepositarSaldo(100);
conta1.cliente = cliente1;


Conta conta2 = new Conta();
conta2.agencia = "22222";
conta2.DepositarSaldo(150);
conta2.cliente = cliente2;







Console.WriteLine("---------------------- CLIENTE 1 ---------------------");
Console.WriteLine("Agencia:  " + conta1.agencia);
Console.WriteLine("Nome:  " + conta1.cliente.nome);
conta1.retornaSaldo(cliente1);


Console.WriteLine("---------------------- CLIENTE 2 ---------------------");
Console.WriteLine("Agencia:  " + conta2.agencia);
Console.WriteLine("Nome:  " + conta2.cliente.nome);
conta2.retornaSaldo(cliente2);

//Console.WriteLine("Cliente:  " + conta1.retornaSaldo);
