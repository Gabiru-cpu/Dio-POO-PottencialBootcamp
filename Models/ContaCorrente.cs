using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int id, decimal saldoInicial)
        {
            id = Id;
            saldo = saldoInicial;
        }
        public int Id { get; set; }
        private decimal saldo;

        public void ShowSaldo(){ Console.WriteLine("Saldo: " + saldo);}

        public void Sacar(decimal valor)
        {
            if (saldo >= valor) { saldo -= valor; Console.WriteLine("Saque realizado"); }

            else { Console.WriteLine("Valor maior que saldo saque não realizado"); }
        }
    }
}