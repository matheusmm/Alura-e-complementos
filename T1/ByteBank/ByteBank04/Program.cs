using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank04
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaAna = new ContaCorrente();
            contaDaAna.titular = "Ana";
            Console.WriteLine(contaDaAna.saldo);
            contaDaAna.Sacar(50);
            Console.WriteLine(contaDaAna.saldo);
            contaDaAna.Depositar(500);
            Console.WriteLine(contaDaAna.saldo);


            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaAna.Transferir(150, contaDaGabriela);

            Console.WriteLine("Saldo da Ana: " +contaDaAna.saldo +
                "\nSaldo da Gabriela: " + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDaAna.Transferir(200, contaDaGabriela);
            Console.WriteLine("Resultado da Transferencia: " + resultadoTransferencia);
            Console.WriteLine("Saldo da Ana: " + contaDaAna.saldo +
                "\nSaldo da Gabriela: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
