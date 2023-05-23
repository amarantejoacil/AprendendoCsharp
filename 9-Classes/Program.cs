using _9_Classes.Contas;
using _9_Classes.Titular;




//exemplo 02

Cliente cliente1 = new Cliente();
cliente1.nome = "Cliente C1";
cliente1.cpf = "111.111.111-11";
cliente1.profissao = "Vendedor";


ContaCorrente conta1 = new ContaCorrente();
conta1.titular = cliente1;
conta1.conta = "11";
conta1.numero_agencia = 1;
conta1.saldo = 100.00;


Console.WriteLine("Titular: " + conta1.titular.nome);
Console.WriteLine("CPF: " + conta1.titular.cpf);
Console.WriteLine("Profissao: " + conta1.titular.profissao);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Ag: " + conta1.numero_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);






//exemplos 01
// tipo / var / instancia
//ContaCorrente contaDoJoacil = new ContaCorrente();
//contaDoJoacil.numero_agencia = 2373;
//contaDoJoacil.titular = "Joacil Amarante";
//contaDoJoacil.conta = "60509-3";
//contaDoJoacil.saldo = 100;


//Console.WriteLine("Saldo Inicial: " + contaDoJoacil.saldo);
//contaDoJoacil.Depositar(150);
//Console.WriteLine("Após o deposito seu Novo Saldo: " + contaDoJoacil.saldo);
//contaDoJoacil.Saque(100);
//Console.WriteLine("Saldo após saque: " + contaDoJoacil.saldo);




//ContaCorrente ContaDaVitoria = new ContaCorrente();
//ContaDaVitoria.numero_agencia = 111;
//ContaDaVitoria.titular = "Vitoria de Paula";
//ContaDaVitoria.conta = "222";
//ContaDaVitoria.saldo = 0;
//Console.WriteLine("--------------------------------------------");
//Console.WriteLine("Saldo Vitoria ANTES TRANSFERENCIA: " + ContaDaVitoria.saldo);
//contaDoJoacil.Transferir(50, ContaDaVitoria);
//Console.WriteLine("Saldo Vitoria: " + ContaDaVitoria.saldo);
//Console.WriteLine("Saldo JOACIL: " + contaDoJoacil.saldo);






