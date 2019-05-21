using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 7 - Condicionais");

            int idadeJ = 16;
            int acompanhante = 21;

            if (idadeJ >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos");
            }
            if (acompanhante >= 18)
            {
                Console.WriteLine("João está acompanhado de um responsavel");
            }
            else
            {
                Console.WriteLine("João é menor de 18");
            }

            Console.ReadLine();
        }
    }
}
