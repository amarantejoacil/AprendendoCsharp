using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Visibilidade
{
    public class Conta
    {
        public string agencia;
        private double saldo;
        public Cliente cliente;


        public void DepositarSaldo(double saldoParm)
        {
            if (saldoParm > 0)
            {
                this.saldo = saldoParm;
            }
            else
            {
                Console.WriteLine("Saldo inválido!");
            }
        }


        public void retornaSaldo(Cliente cliente)
        {
            Console.WriteLine(this.saldo);
        }

    }
}
