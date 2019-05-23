using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank05
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Ana = new Cliente();
            Ana.nome = "Ana";
            Ana.profissao = "Web Dev";
            Ana.cpf = "265.459.852-21";
            ContaCorrente conta = new ContaCorrente();
            conta.titular = Ana;
            conta.saldo = 500;
            conta.agencia = 420;
            conta.numero = 4206901;
            //Console.WriteLine(conta.titular.nome);

            conta.titular = new Cliente();
            conta.titular.nome = "Clara Costa";
            conta.titular.cpf = "434.562.878-20";
            conta.titular.profissao = "Designer de interiores";
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);


            Console.ReadLine();
        }
    }
}
