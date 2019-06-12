using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Mochila", 250.00));
            orcamento.AdicionaItem(new Item("Cadeira", 235.00));
            orcamento.AdicionaItem(new Item("Lápis", 5));
            orcamento.AdicionaItem(new Item("Apagador",5));
            orcamento.AdicionaItem(new Item("Caneta", 5));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }

    }
}
