using System;
using System.Collections;

namespace GameConsoleApp 
{
    public class Item<T> : GameConsoleApp.GItem{
        public T TipoItem { get; private set; }
        public string Subtipo { get; set; } 

        public Item(string Desc, int Qtd, string Nome, double Peso)
            :base(Desc, Qtd, Nome, Peso)
        {

        }
        public Item(T tipoItem, string subTipo, string Desc, int Qtd, string Nome, double Peso)
            : base(Desc, Qtd, Nome, Peso)
        {
            this.TipoItem = tipoItem;
            this.Subtipo = subTipo;
        }
    }
}