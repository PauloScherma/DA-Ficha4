using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereClientes
{
     class Cliente
    {
        public string nome { get; set; }
        public string nif { get; set; }
        public int total { get; set; }
        public List<Compra> compras { get; set; }

        public Cliente(string nome, string nif, int total)
        {
            this.nome = nome;
            this.nif = nif;
            this.total = total;
            this.compras = new List<Compra>();
        }

        //adiciona à list
        public void addCompra(Compra compra)
        {
            this.compras.Add(compra);
            this.total += compra.totalCompra;
        }

        //remove da list 
        public void removeCompra(Compra compra)
        {
            this.compras.Remove(compra);
            this.total -= compra.totalCompra;
        }

        public override string ToString()
        {
            string texto = this.nome + " (" + this.nif + ") ";
            return texto;
        }
    }
}
