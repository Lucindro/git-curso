using System;
using System.Globalization;
using System.Numerics;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Transacao t = new Transacao();
            Console.WriteLine("informe seu nome:");
            string nome= Console.ReadLine();

            Console.WriteLine("Conta:");
            int conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Saldo inicial?");
            char resp = char.Parse(Console.ReadLine());
            if (resp=='s')
            {
                Console.WriteLine("Qual o valor");
                float saldo = float.Parse(Console.ReadLine());
                t = new Transacao(nome, conta, saldo);
            }
            else
            {
                t = new Transacao(nome, conta);
            }
            
            
            Console.WriteLine("Dados da conta");
            Console.WriteLine("Conta: " +
                t.Conta+
                ", Titular: "+
                t.Nome+
                ", Saldo: $"+
                t.Saldo);


            Console.WriteLine("Entre com um valor de deposito:");
            float dep = float.Parse(Console.ReadLine());
            t.Deposito(dep);
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine("Conta: " +
                t.Conta +
                ", Titular: " +
                t.Nome +
                ", Saldo: $" +
                t.Saldo);

            Console.WriteLine("Entre com um valor de saque:");
            float saq = float.Parse(Console.ReadLine());
             t.Saque(saq);
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine("Conta: " +
                t.Conta +
                ", Titular: " +
                t.Nome +
                ", Saldo: $" +
               t.Saldo);

        }
    }
}
