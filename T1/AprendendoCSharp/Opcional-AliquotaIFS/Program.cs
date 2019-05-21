using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        if(salario < 1900.0)
        {
            Console.WriteLine("Não é necessário declarar imposto");
        }

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("IR é de 7.5% e pode deduzir R$142 na declaração");
            Console.WriteLine("Salario com dedução:" + (salario - 142));
        }
        if (salario >= 2800.01 && salario <= 3751.0)
        {
            Console.WriteLine("IR é de 15% e pode deduzir R$350 na declaração");
            Console.WriteLine("Salario com dedução:" + (salario - 350));

        }
        if (salario >= 3751.01 && salario <= 4664.00)
        {
            Console.WriteLine("IR é de 22.5% e pode deduzir R$636 na declaração");
            Console.WriteLine("Salario com dedução:" + (salario - 636));
        }
    Console.ReadLine();
    }
}