using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    abstract class Filtro
    {
        System.DateTime mescheck = new System.DateTime();

        protected Filtro FiltroChecagem { get; private set; }
        public Filtro() { }
        public abstract IList<Conta> Filtra(IList<Conta> contas);
        public Filtro(Filtro filtroChecagem)
        {
            this.FiltroChecagem = filtroChecagem;
        }
        protected IList<Conta> ProximaChecagem(IList<Conta> contas)
        {
            if (FiltroChecagem != null) return FiltroChecagem.Filtra(contas);
            else return new List<Conta>();
        }
    }
}

