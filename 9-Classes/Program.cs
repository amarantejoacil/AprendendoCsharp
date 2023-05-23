using _9_Classes;


// tipo / var / instancia

ContaCorrente contaDoJoacil = new ContaCorrente();
contaDoJoacil.numero_agencia = 2373;
contaDoJoacil.titular = "Joacil Amarante";
contaDoJoacil.conta = "60509-3";
contaDoJoacil.saldo = 100;


Console.WriteLine("Saldo Inicial: " + contaDoJoacil.saldo);
contaDoJoacil.Depositar(150);
Console.WriteLine("Após o deposito seu Novo Saldo: " + contaDoJoacil.saldo);
contaDoJoacil.Saque(100);
Console.WriteLine("Saldo após saque: " + contaDoJoacil.saldo);




ContaCorrente ContaDaVitoria = new ContaCorrente();
ContaDaVitoria.numero_agencia = 111;
ContaDaVitoria.titular = "Vitoria de Paula";
ContaDaVitoria.conta = "222";
ContaDaVitoria.saldo = 0;
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Saldo Vitoria ANTES TRANSFERENCIA: " + ContaDaVitoria.saldo);
contaDoJoacil.Transferir(50, ContaDaVitoria);
Console.WriteLine("Saldo Vitoria: " + ContaDaVitoria.saldo);
Console.WriteLine("Saldo JOACIL: " + contaDoJoacil.saldo);




