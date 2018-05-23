using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApp
{
    class FichaJogador
    {
        public Dictionary<string, int> Atributos { get; set; }
        public string Nome { get; set; }
        public string Historia { get; set; }
        public Bag Mochila { get; set; }


        public FichaJogador(Dictionary<string, int> atributos)
        {
            this.Atributos = atributos;
        }

        public FichaJogador(int f, int h, int i, int r, int a, int pdf, string nome, string historia, Bag mochila)
        {
            Atributos.Add("Força", f);
            Atributos.Add("Habilidade", h);
            Atributos.Add("Inteligência", i);
            Atributos.Add("Resistencia", r);
            Atributos.Add("Armadura", a);
            Atributos.Add("Poder de Fogo", pdf);

            this.Nome = Nome;
            this.Historia = historia;
            this.Mochila = mochila;
        }
    }
}
