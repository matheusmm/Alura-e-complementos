﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap2
{
    public class Piano
    {
            public void Toca(IList<INota> notas1)
        {
            foreach (var nota in notas1)
            {
                Console.Beep(nota.Frequencia, 300);
            }

        }
    }
}
