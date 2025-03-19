using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GereClientes
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxCliente.SelectedIndex;
            
            //vê qual é o cliente e mostra o nome e o nif nas respetivas labels
            if (index > -1) { 
                Cliente cliente = (Cliente)listBoxCliente.Items[index];
                labelNome.Text = cliente.nome;
                labelNif.Text = cliente.nif;
            }
        }
        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string nif = textBoxNif.Text;
            int total = 0;

            //não adicionar vazio
            if (string.IsNullOrEmpty(textBoxNome.Text))
            {
                return;
            }

            //adiciona item à listBoxCliente
            Cliente cliente = new Cliente(nome, nif, total);
            listBoxCliente.Items.Add(cliente);
        }

        private void buttonAdicionarLinha_Click(object sender, EventArgs e)
        {
            int soma = 0;
            string descricao = textBoxDescricao.Text;
            
            //parece estranho mas está só a passar uma string para int
            int valor = Int32.Parse(textBoxValor.Text);

            //adicionar um item à listBOxLinhasCompra
            LinhaDeCompra compra = new LinhaDeCompra(descricao, valor);
            listBoxLinhasCompra.Items.Add(compra);
            
            //loop para somar os valores da variavel "valor" da class "LinhaDeCompra" e mostrar depois
            foreach (LinhaDeCompra index in listBoxLinhasCompra.Items)
            {
                soma += index.valor;
            }
            labelTotalLinhaDeCompra.Text = "" + soma;
        }

        private void buttonCriarCompra_Click(object sender, EventArgs e)
        {
            DateTime dataAgora = DateTime.Now;
            int totalCompra = Int32.Parse(labelTotalLinhaDeCompra.Text);
            int soma = 0;

            Compra compra = new Compra(dataAgora, totalCompra);
            listBoxCompra.Items.Add(compra);

            //loop que percorre a listBoxCompra e depois soma todos os valores do atributo "totalLinhaCompra" da clase "Compra"
            foreach (Compra totalLinhaCompra in listBoxCompra.Items)
            {
                soma += totalLinhaCompra.totalCompra;
            }
            labelTotal.Text = soma + "";
        }

        //apaga a um item da listBoxLinhasCompra
        private void buttonApagarLinhaCompra_Click(object sender, EventArgs e)
        {
            int index = listBoxLinhasCompra.SelectedIndex;
            int soma=0;

            if (index > -1)
            {
                LinhaDeCompra linhaDeCompra = (LinhaDeCompra)listBoxLinhasCompra.Items[index];
                listBoxLinhasCompra.Items.Remove(linhaDeCompra);
            }
            //loop para somar os valores da variavel "valor" da class "LinhaDeCompra" e mostrar depois
            foreach (LinhaDeCompra index1 in listBoxLinhasCompra.Items)
            {
                soma += index1.valor;
            }
            labelTotalLinhaDeCompra.Text = "" + soma;
        }
        //apaga um item da listBoxCompra
        private void buttonApagarCompra_Click(object sender, EventArgs e)
        {
            int index = listBoxCompra.SelectedIndex;

            if (index > -1)
            {
                Compra compra = (Compra)listBoxCompra.Items[index];
                listBoxCompra.Items.Remove(compra);
            }
        }
    }
}
