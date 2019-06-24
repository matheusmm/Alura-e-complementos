﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV() : base() { }
        public IKCV(Imposto outroImposto) : base(outroImposto) { }
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
            {
            return orcamento.Valor > 500 && TemItemMaiorQueCemReaisNo(orcamento);
            
        }
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool TemItemMaiorQueCemReaisNo(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }
    }
}
