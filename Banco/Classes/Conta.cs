using Banco.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banco
{
    class Conta
    {


        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private TipoConta TipoConta { get; set; }


        public Conta(string nome, double saldo, double credito, TipoConta tipoConta)
        {

            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
            this.TipoConta = tipoConta;
        }

        public bool sacarSaldo(double valor)
        {


            if (this.Saldo - valor < (this.Credito * -1))
            {

                Console.WriteLine("Seu Saldo é insuficiente");

                return false;
            }

            this.Saldo -= valor;
            Console.WriteLine("O Saldo atual da sua conta de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }

        public void depositar(double valor)
        {
            this.Saldo += valor;

            Console.WriteLine("O Saldo atual da sua conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void transferir(double valor, Conta conta)
        {

            if (sacarSaldo(valor))
            {
                conta.depositar(valor);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
            return retorno;
        }
    }
}



