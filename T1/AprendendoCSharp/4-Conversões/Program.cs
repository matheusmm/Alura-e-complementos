using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Conversões
{
    class Program
    {
        static void Main(string[] args)
        {
            //int = até 32 bits
            //long = 64 bits
            //short 16 bits
            //float suporta casas decimais like double
            double salario = 1200.50;
            int salarioEmInteiro = (int)salario;
            long idade = 130000000000000;
            short quantidadeDeProdutos = 15000;
            float altura = 3.141592f;

            Console.WriteLine("Executando projeto 4");
            Console.WriteLine(salarioEmInteiro);
            Console.WriteLine(idade);
            Console.WriteLine(quantidadeDeProdutos);
            Console.WriteLine(altura);
            Console.WriteLine("Pressione uma tecla para sair");
            Console.ReadLine();
        }
    }
    }
}
