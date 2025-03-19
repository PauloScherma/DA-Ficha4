using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    class Cliente
    {
        public string nome;
        public  string nif;
        public int total;

        public Cliente(string nome, string nif, int total)
        {
            this.nome = nome;
            this.nif = nif;
            this.total = total;
        }

        public override string ToString()
        {
            string texto = this.nome + " (" + this.nif + ") ";
            return texto;
        }
    }
}
