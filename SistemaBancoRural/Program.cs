using System;
using SistemaBancoRural.Contas;

namespace SistemaBancoRural
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(TipoConta.ContaCorrente, "1226-2");
            Console.WriteLine("Mostrar saldo:");
            conta.Num = "123";
            conta.Depositar(500);
            conta.Sacar(300);
            Console.WriteLine(conta.GetSaldo().ToString());
            Console.ReadLine();
        }
    }
}
