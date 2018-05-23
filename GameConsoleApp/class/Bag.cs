using System;
using System.Collections.Generic;

namespace GameConsoleApp
{
    class Bag
    {
        public Bag()
        {


        }

        public Bag(List<GItem> Itens)
        {
            this.Itens = Itens;
            this.Peso = calculaPesoAtual();
        }

        private List<GItem> Itens { get; set; }
        public double Peso { get; set; }

        public string removerItem(GItem item)
        {
            Itens.Remove(item);
            this.Peso = calculaPesoAtual();
            return "Item " + item + "removido!";
        }

        public string adicionarItem(GItem item)
        {
            Itens.Add(item);
            this.Peso = calculaPesoAtual();
            return "Item " + item + " adicionado!";
        }

        public double calculaPesoAtual()
        {
            double pesoTotal = 0;
            foreach (var equipamento in Itens)
            {
                pesoTotal += equipamento.Peso;
            }

            return pesoTotal;
        }
    }
}
