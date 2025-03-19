using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    class LinhaDeCompra
    {
        public string descricao;
        public int valor;

        public LinhaDeCompra(string descricao, int valor)
        {
            this.descricao = descricao;
            this.valor = valor;
        }

        public override string ToString()
        {
            string texto = this.valor + "€ " + this.descricao;
            return texto;
        }
    }
}
