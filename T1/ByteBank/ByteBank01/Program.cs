﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank01
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agencia: "+ contaDaGabriela.agencia + 
                "\nNúmero: " + contaDaGabriela.numero +
                "\nSaldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo: " +contaDaGabriela.saldo);

            Console.ReadLine();

        }
    }
}

