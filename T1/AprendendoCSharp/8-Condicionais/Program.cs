﻿using System;
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
            // int responsavel = 21;
            bool responsavel = true;

            if (idadeJ >= 18 && responsavel == true)
            {
                Console.WriteLine("Pode entrar");
            }      
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
