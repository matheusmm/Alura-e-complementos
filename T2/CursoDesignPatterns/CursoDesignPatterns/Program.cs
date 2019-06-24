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
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.AdicionaAcao(new Multiplica(2));
            builder.AdicionaAcao(new Multiplica(3));
            builder.AdicionaAcao(new Multiplica(5.5));

            NotaFiscal notaFiscal = builder.Empresa("Caelum")
                .UsarCnpj("123.456.789/0001-10")
                .ComItem(new ItemDaNota("item 1", 100.0))
                .ComItem(new ItemDaNota("item 2", 200.0))
                .ComItem(new ItemDaNota("item 3", 300.0))
                .Constroi();

            Console.ReadKey();
        }

    }
}
