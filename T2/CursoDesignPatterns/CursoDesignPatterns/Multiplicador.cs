using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Multiplica : AcaoAposGerarNota
    {
        public double ValorASerMultiplicado { get; set; }
        public Multiplica(double fator)
        {this.ValorASerMultiplicado = fator;}
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(NotaFiscal.Valor * this.ValorASerMultiplicado); 
        }
    }
}
