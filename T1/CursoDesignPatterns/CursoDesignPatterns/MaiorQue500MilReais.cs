using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class MaiorQue500MilReais : Filtro
    {
           public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtroCheck = new List<Conta>();
            foreach (Conta item in contas)
            {
                if (item.Saldo > 500000)
                {
                    filtroCheck.Add(item);
                }
            }return filtroCheck;
        }
    }
}
