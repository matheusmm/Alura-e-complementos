using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_InvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 12 - Investimento a longo prazo");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <=12 ; contadorMes++ )
                {
                    valorInvestido *= fatorRendimento;
                }

                Console.WriteLine("Tempo de investimento foi de " + contadorAno + " ano(s), retornando R$" + valorInvestido + "\n");
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Ao termino você terá R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
