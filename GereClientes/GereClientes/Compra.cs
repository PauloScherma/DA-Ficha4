using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    class Compra 
    {
        public DateTime dataAgora;
        public int totalCompra;
        
        public Compra(DateTime dataAgora, int totalCompra)
        {
            this.dataAgora = dataAgora;
            this.totalCompra = totalCompra;
        }
        public override string ToString()
        {
            string texto = this.dataAgora + " || " + this.totalCompra + "€";
            return texto;
        }
    }
}
