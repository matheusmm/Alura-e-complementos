using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 10 - Calcula poupança");

            double investimento = 1000;
            int ContadorMeses = 1;

            while (ContadorMeses <= 12)
            {
                investimento = investimento + investimento * 0.0036;
                Console.WriteLine("Após " + ContadorMeses +" mês, você terá R$" + investimento);
                ContadorMeses = ContadorMeses +=1;

            }
            Console.ReadLine();
        }
    }
}

