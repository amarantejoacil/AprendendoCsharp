using ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public Cliente titular;
        public double saldo;

        public ContaCorrente(int numero_agencia, string conta)
        {
            this.numero_agencia = numero_agencia;
            this.conta = conta;




            /*
            try
            {
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Ocorreu um erro, não é possivel dividir por Zero!");
            }
            */
            TotalDeContasCriadas++;
        }

        public static int TotalDeContasCriadas { get; private set; }


        public static float TaxaOperacao { get; private set; }


        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Saque(double Valor)
        {
            if (saldo < Valor)
            {
                Console.WriteLine("Operação cancelada, você não possui saldo insuficiente. Seu limite máximo para saque hoje é de: R$" + saldo);
            }
            else
            {
                saldo -= Valor;
            }

        }

        public bool Transferir(double Valor, ContaCorrente Destino)
        {
            if (saldo < Valor)
            {
                saldo += Valor;
                Console.WriteLine("Saldo ínsuficiente para TRANSFERENCIA!!!");
                return false;
            }
            else
            {
                Saque(Valor);
                Destino.Depositar(Valor);
                return true;
            }

        }

    }



}
