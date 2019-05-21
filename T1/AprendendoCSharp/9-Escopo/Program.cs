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

            int idadeJ = 18;
            bool responsavel = true;
            string mensagemAdicional;

            if (responsavel == true)
            {
                mensagemAdicional = "João está com Responsável";
;
            }
            else
            {
                mensagemAdicional = "João não está com Responsável";
            }

            if (idadeJ >= 18 && responsavel == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
