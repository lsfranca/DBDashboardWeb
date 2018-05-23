using System;
using System.Collections;

namespace GameConsoleApp
{
    public abstract class GItem{
        public GItem(string Desc, int Quantidade, string Nome, double Peso)
        {
            this.Desc = Desc;
            this.Quantidade = Quantidade;
            this.Nome = Nome;
            this.Peso = Peso;
        }
        private string Desc {get;set;}
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }

    }
}