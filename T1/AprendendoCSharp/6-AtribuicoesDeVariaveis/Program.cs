using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 6");

            int idade = 19;
            int idadeM = idade;
            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeM);

            Console.ReadLine();
        }
    }
}
