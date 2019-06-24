using DesignPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap5
{
    public class Impressora : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.esquerda.Aceita(this);
            Console.Write(" + ");
            soma.direita.Aceita(this);
            Console.Write(")");
        }
        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.esquerda.Aceita(this);
            Console.Write(" - ");
            subtracao.direita.Aceita(this);
            Console.Write(")");
        }
        public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            multiplicacao.esquerda.Aceita(this);
            Console.Write(" * ");
            multiplicacao.direita.Aceita(this);
            Console.Write(")");
        }
        public void ImprimeDivisao(Divisao divisao)
        {
            Console.Write("(");
            divisao.esquerda.Aceita(this);
            Console.Write(" / ");
            divisao.direita.Aceita(this);
            Console.Write(")");
        }
        public void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada)
        {
            Console.Write("²√");
            raizQuadrada.expressao.Aceita(this);
            
        }
        public void ImprimeNumero(Numero numeroI)
        {
            Console.Write(numeroI.numero);
        }
    }
}