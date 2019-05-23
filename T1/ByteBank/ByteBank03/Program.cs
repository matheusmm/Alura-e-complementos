using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank03
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaAna = new ContaCorrente();
            contaDaAna.titular = "Ana";
            contaDaAna.agencia = 836;
            contaDaAna.numero = 8630245;

            ContaCorrente contaDaAnaM = new ContaCorrente();
            contaDaAna.titular = "Ana M.";
            contaDaAna.agencia = 836;
            contaDaAna.numero = 8632857;

            Console.WriteLine(contaDaAna == contaDaAnaM);

            Console.ReadLine();
        }
    }
}
