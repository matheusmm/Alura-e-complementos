using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    abstract class TemplateRelatorio
    {
        public abstract void Head();
        public abstract void Body(IList<Conta> contas);
        public abstract void Foot();

        public void Imprime(IList<Conta> contas)
        {   
            Head();
            Body(contas);
            Foot();
        }
    }
}

