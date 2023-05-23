using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Classes
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;


        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Saque(double Valor)
        {
            if (this.saldo < Valor)
            {
                Console.WriteLine("Operação cancelada, você não possui saldo insuficiente. Seu limite máximo para saque hoje é de: R$" + this.saldo);
            }
            else
            {
                this.saldo -= Valor;
            }

        }

        public bool Transferir(double Valor, ContaCorrente Destino)
        {
            if (this.saldo < Valor)
            {
                this.saldo += Valor;
                Console.WriteLine("Saldo ínsuficiente para TRANSFERENCIA!!!");
                return false;
            }
            else
            {
                this.Saque(Valor);
                Destino.Depositar(Valor);
                return true;
            }

        }

    }



}
