using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Primeiro
{
    class Transacao
    {
        private string _nome;
        public int Conta { get; private set; }
        public float Saldo { get; private set; }

        public Transacao()
        {
        }

        public Transacao(string nome, int conta)
        {
            _nome = nome;
            this.Conta = conta;
            Saldo = 0;
        }

        public Transacao(string nome, int conta, float saldo) : this(nome, conta)
        {
            Saldo = saldo;
        }
        public string Nome
        {
            get { return _nome; }
            set { 
                if(value!=null || value.Length > 1) { _nome = value; }
            }
        }


        /* OUTROS METODOS*/
        public void Deposito(float dep)
        {
            
            Saldo= Saldo+ dep;
            
        }
        public void Saque(float saq)
        {
            
            Saldo= Saldo - (saq+5);
            
        }
    }
     
}
