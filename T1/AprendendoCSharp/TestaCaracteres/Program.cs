﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
                        char letra = 'a';
                Console.WriteLine(letra);
                char valor;
                
                //valor = 65; Não irá compilar
                //Console.WriteLine(valor);

                valor = (char)(65 + 1);         
                Console.WriteLine(valor);

                string palavra = "alura cursos online de tecnologia";
                Console.WriteLine(palavra);

                palavra = palavra + 2020;
                Console.WriteLine(palavra);
            }
        }
    }
   