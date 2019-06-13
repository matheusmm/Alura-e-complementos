using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class CNegativa : EstadoDaConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0)
            {
                conta.Estado = new CPositiva();
            }
        }

        public void Saca(Conta conta, double valor)
        {
            throw new NotImplementedException("Conta está negativa, saque não pode ser realizado");
        }
    }
}
