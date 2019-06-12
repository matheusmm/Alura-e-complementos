using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public string Agencia { get; private set; }
        public double Saldo { get; private set; }
        public string Titular { get; private set; }
        public string NConta { get; private set; }
        public DateTime DataCriacao { get; private set; }

        public void NovaConta(double valor, DateTime DataAUsar)
        {
            this.Saldo = valor;
            this.DataCriacao = DataAUsar;
        }
        public void Deposita(double valor, string titular)
        {
            this.Titular = titular;
            this.Saldo += valor;
        }
    }
    enum Formato { XML, CSV, PORCENTO}

    class Requisicao
    {
        public Formato Formato { get; private set; }
        public Requisicao (Formato formato)
        {
            this.Formato = formato;
        }
    }

}
