using System;
using System.Threading;


using _17_TesteExceptions.JoacilExpection;

void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===        ATENDIMENTO      ===");
            Console.WriteLine("=== 1 - Cadastrar Contas    ===");
            Console.WriteLine("=== 2 - Listar Contas       ===");
            Console.WriteLine("=== 3 - Remover Contas      ===");
            Console.WriteLine("=== 4 - Ordenar Contas      ===");
            Console.WriteLine("=== 5 - Pesquisar Contas    ===");
            Console.WriteLine("=== 6 - Sair do sistema     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.Write("Digite a Opção desejada: ");

            try
            {
                opcao = Console.ReadLine()[0];

            }
            catch (Exception excecao)
            {

                throw new JoacilException(excecao.Message);


            }

            switch (opcao)
            {
                case '1':
                    Console.WriteLine("Cadastrar contas");
                    Thread.Sleep(1000);
                    break;

                case '2':
                    Console.WriteLine("Lista conta");
                    Thread.Sleep(1000);
                    break;
                case '6':
                    Console.WriteLine("Encerrar");
                    Thread.Sleep(1000);
                    break;
                default:
                    Console.WriteLine("Opção não implementada.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
    catch (JoacilException excecao)
    {
        Console.WriteLine($"{excecao.Message}"); ;
    }

}

AtendimentoCliente();
