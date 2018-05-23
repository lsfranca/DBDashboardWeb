using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApp
{
    static class Dado
    {
       
        public static int rolarDado()
        {
            return new Random().Next(1, 6);
        }

        public static int rolarDado(int modificador)
        {
            return new Random().Next(1, 6) + modificador;
        }

    }
}
