﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura0201
{
    public class contaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;

        public void depositar(double valor)
        {
            this.saldo += valor;
        }

    }
}
