using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Carlos = new Funcionario(1);
            Carlos.Nome = "Carlos";
            Carlos.CPF = "546.585.585-02";
            Carlos.Salario = 2000;

            Console.WriteLine(Carlos.Nome);
            Console.WriteLine(Carlos.GetBonificacao());

            Console.ReadLine();
        }
    }
}
