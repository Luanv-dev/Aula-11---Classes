﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11.Operacoes
{
    internal class Soma : Operacao
    {
        public Soma() : base("+", "Soma")
        {
        }

        public override decimal calcular(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }
    }
}
