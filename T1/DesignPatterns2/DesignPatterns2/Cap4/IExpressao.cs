using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap4
{
    public interface IExpressao
    {
        float Avalia();
        void Aceita(IVisitor impressora);
    }
    public class Subtracao : IExpressao
    {

        public IExpressao esquerda { get; private set; }
        public IExpressao direita { get; private set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;

        }

        public float Avalia()
        {
            float resultadoDaEsquerda = esquerda.Avalia();
            float resultadoDaDireita = direita.Avalia();
            return resultadoDaEsquerda - resultadoDaDireita;
        }
        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }
    }
}

public class Soma : IExpressao
{
    public IExpressao esquerda { get; private set; }
    public IExpressao direita { get; private set; }
    public Soma(IExpressao esquerda, IExpressao direita)
    {
        this.esquerda = esquerda;
        this.direita = direita;
    }
    public float Avalia()
    {
        float resultadoDaEsquerda = esquerda.Avalia();
        float resultadoDaDireita = direita.Avalia();
        return resultadoDaEsquerda + resultadoDaDireita;
    }
    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeSoma(this);
    }
}
    
    public class Multiplicacao : IExpressao
{

    public IExpressao esquerda { get; private set; }
    public IExpressao direita { get; private set; }

    public Multiplicacao(IExpressao esquerda, IExpressao direita)
    {
        this.esquerda = esquerda;
        this.direita = direita;
    }

    public float Avalia()
    {
        float resultadoDaEsquerda = esquerda.Avalia();
        float resultadoDaDireita = direita.Avalia();
        return resultadoDaEsquerda * resultadoDaDireita;
    }
    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeMultiplicacao(this);
    }
}
    
    public class Divisao : IExpressao
{

    public IExpressao esquerda { get; private set; }
    public IExpressao direita { get; private set; }
    public Divisao(IExpressao esquerda, IExpressao direita)
    {
        this.esquerda = esquerda;
        this.direita = direita;
    }

    public float Avalia()
    {
        float resultadoDaEsquerda = esquerda.Avalia();
        float resultadoDaDireita = direita.Avalia();
        return resultadoDaEsquerda / resultadoDaDireita;
    }
    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeDivisao(this);
    }
}
    
    public class RaizQuadrada : IExpressao
{

    public IExpressao expressao { get; private set; }


    public RaizQuadrada(IExpressao esquerda)
    {
        this.expressao = esquerda;
    }

    public float Avalia()
    {
        return (float)Math.Sqrt(expressao.Avalia());
    }
    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeRaizQuadrada(this);
    }
}
    public class Numero : IExpressao
{
    public float numero { get; private set; }
    public Numero(float numero)
    {
        this.numero = numero;
    }
    public float Avalia()
    {
        return numero;
    }
    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeNumero(this);
    }
}