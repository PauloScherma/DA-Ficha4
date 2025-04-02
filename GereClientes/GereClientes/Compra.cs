using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
     class Compra 
    {
        public DateTime dataAgora { get; }
        public int totalCompra { get; set;}
        
        public List<Item> itens = new List<Item>();
        public Compra()
        {
            this.dataAgora = DateTime.Now;
            this.totalCompra = 0;
            this.itens = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.itens.Add(item);
            this.totalCompra += item.valor;
        }
        public void removeItem(Item item)
        {
            this.itens.Remove(item);
            this.totalCompra -= item.valor;
        }
        public override string ToString()
        {
            string texto = this.dataAgora + " || " + this.totalCompra + "€";
            return texto;
        }
    }
}
