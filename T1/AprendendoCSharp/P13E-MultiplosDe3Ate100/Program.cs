using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13E_MultiplosDe3Ate100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimindo todos os multiplos de 3 entre 1 e 100");
            for (int numero = 3; numero < 100; numero += 3)
            {
                Console.WriteLine(numero);
            }
            Console.ReadLine();
        }
    }
}
