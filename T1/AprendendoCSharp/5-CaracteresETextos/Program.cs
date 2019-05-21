using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 5 - caracteres e textos");

            char Letra = 'a';
            Console.WriteLine(Letra);

            Letra = (char)65; //"A" na tabela Ascii
            Console.WriteLine(Letra);

            Letra = (char)(Letra + 1);
            Console.WriteLine(Letra);

            string titulo = "\n Curso alura CSharp";
            string cursos = @"- .Net 
- Java
- Javascript"; //O @faz com que tudo dentro das aspas seja considerado, inclusive espaços
            Console.WriteLine(titulo);
            Console.WriteLine(cursos);


            Console.ReadLine();
        }
    }
}