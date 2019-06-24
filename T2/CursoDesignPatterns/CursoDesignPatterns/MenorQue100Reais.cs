using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class MenorQue100Reais : Filtro
    {
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtroCheck = new List<Conta>();
            foreach (Conta item in contas)
            {
                if (item.Saldo < 100)
                {
                    filtroCheck.Add(item);
                }
            }return filtroCheck;
        }
    }
}
