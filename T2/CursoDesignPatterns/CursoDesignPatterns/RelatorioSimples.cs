using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class RelatorioSimples : TemplateRelatorio
    {
        public override void Body(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Titular + "/ Saldo: R$"+ c.Saldo);
            }
        }
        public override void Foot()
        {
            Console.WriteLine("+55-12-2333-4444");   
        }

        public override void Head()
        {
            Console.WriteLine("NA Banco");
        }
    }
}
