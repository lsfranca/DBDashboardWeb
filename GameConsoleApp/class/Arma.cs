using System;
using System.Collections.Generic;

namespace GameConsoleApp
{
    class Arma{

        public bool Magica { get; set; }
        public char Elemento { get; set; }
        public int[] ReqMin { get; set; }

        public Arma(bool magica, char elemento, int[] reqMin)
        {
            Magica = magica;
            Elemento = elemento;
            ReqMin = reqMin;
        }
    }
}