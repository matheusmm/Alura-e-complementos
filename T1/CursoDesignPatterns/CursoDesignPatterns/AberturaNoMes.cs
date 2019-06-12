using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class AberturaNoMes : Filtro
    {
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            int esseMes = DateTime.Now.Month;

            IList<Conta> filtroCheck = new List<Conta>();
            foreach (Conta item in contas)
            {
                if (item.DataCriacao.Month.Equals(DateTime.Now.Month))
                {
                    filtroCheck.Add(item);
                }
            }
            return filtroCheck;
        }
    }
}