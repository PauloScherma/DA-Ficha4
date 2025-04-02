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
            List<Cliente> clientes;
            public Form1()
            {
                InitializeComponent();
                clientes = new List<Cliente>();
            }
            
            //evento que acontece quando o cliente é selecionado
            private void listBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
            {
                int index = listBoxCliente.SelectedIndex;

            //vê qual é o cliente e mostra o nome e o nif nas respetivas labels
            if (index > -1) 
                { 
                    Cliente cliente = (Cliente)listBoxCliente.Items[index];
                    labelNome.Text = cliente.nome;
                    labelNif.Text = cliente.nif;
                    labelTotal.Text = Convert.ToString(cliente.total);
                    
                    atualizarCompras();
                    listBoxLinhasCompra.DataSource = null;

                    return;
                }
            }

            //evento que acontece quando a compra é selecionada
            private void listBoxCompra_SelectedIndexChanged_1(object sender, EventArgs e)
            {
                int index = listBoxCompra.SelectedIndex;
                Compra compraSelecionada = (Compra)listBoxCompra.SelectedItem;

                //atualiza para os itens das compra certa
                if (index > -1)
                {
                    Compra compra = (Compra)listBoxCompra.Items[index];
                    
                    atualizarItens();

                    labelTotalLinhaDeCompra.Text = compraSelecionada.totalCompra.ToString();

                    return;
                }
            }

            //evento quando clicasse no botao adicionar cliente
            private void buttonAdicionarCliente_Click(object sender, EventArgs e)
            {   
                int index = listBoxCliente.SelectedIndex;
                string nome = textBoxNome.Text.Trim();
                string nif = textBoxNif.Text.Trim();
                int total = 0;

                //verifica se o textBoxNome e Nif estão vazias
                if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxNif.Text))
                {
                    MessageBox.Show("Preencha o nome e o NIF.");
                    return;
                }
                else 
                { 
                    
                    //adiciona um cliente
                    Cliente cliente = new Cliente(nome, nif, total);
                    clientes.Add(cliente);
                    labelTotal.Text = Convert.ToString(cliente.total);
                    
                    //atualiza a listBoxCliente
                    listBoxCliente.DataSource = null;
                    listBoxCliente.DataSource = clientes;

                    //seleciona o index do cliente criado
                    listBoxCliente.SelectedIndex = index + 1;
                }
            }

            //evento quando clicasse no botao criar compra
            private void buttonCriarCompra_Click(object sender, EventArgs e)
            {
                int index = listBoxCompra.SelectedIndex;
                DateTime dataAgora = DateTime.Now;
                Cliente clienteSelecionado = (Cliente)listBoxCliente.SelectedItem;

                //verifica se tem uma cliente selecionado
                if (clienteSelecionado == null)
                {
                    MessageBox.Show("Selecione um cliente antes de criar uma compra.");
                    return;
                }
                else
                {
                    //adiciona uma compra 
                    Compra compra = new Compra();
                    clienteSelecionado.addCompra(compra);
                    labelTotal.Text = Convert.ToString(compra.totalCompra);
                    
                    //atualizar as listboxes
                    atualizarCompras();

                    //seleciona o index da compra criada
                    listBoxCompra.SelectedIndex = index + 1;
                }
            }

            //evento quando clicasse no botao apagar compra
            private void buttonApagarCompra_Click(object sender, EventArgs e)
            {
                Cliente clienteSelecionado = (Cliente)listBoxCliente.SelectedItem;
                Compra compraSelecionada = (Compra)listBoxCompra.SelectedItem;

                //verifica se tem uma cliente selecionado
                if (clienteSelecionado == null)
                {
                    MessageBox.Show("Selecione uma compra antes de apaga-la");
                    return;
                }
                else
                {
                    //remove uma compra 
                    clienteSelecionado.compras.Remove(compraSelecionada);
                    clienteSelecionado.removeCompra(compraSelecionada);

                    atualizarCompras();
                    listBoxLinhasCompra.DataSource = null;
                }
            }

            //evento quando clicasse no botao adicionar linha
            private void buttonAdicionarLinha_Click(object sender, EventArgs e)
            {
                
                int valor = Int32.Parse(textBoxValor.Text);
                int index = listBoxCompra.SelectedIndex;
                int indexLinha = listBoxLinhasCompra.SelectedIndex;
                string descricao = textBoxDescricao.Text;
                Cliente clienteSelecionado = (Cliente)listBoxCliente.SelectedItem;
                Compra compraSelecionada = (Compra)listBoxCompra.SelectedItem;
                Item itemSelecionado = (Item)listBoxLinhasCompra.SelectedItem;
                

                //verifica se tem uma compra selecionado
                if(compraSelecionada == null)
                {
                    MessageBox.Show("Selecione uma compra antes de criar um item.");
                    return;
                }
                else
                {
                    //adicionar um item
                    Item item = new Item(descricao, valor);
                    compraSelecionada.addItem(item);

                    atualizarItens();
                    atualizarCompras();

                    //mantem a compra selecionada
                    listBoxCompra.SelectedIndex = index;
                    listBoxLinhasCompra.SelectedIndex = indexLinha + 1;

                    //mostra na label o valor das linhas
                    labelTotalLinhaDeCompra.Text = compraSelecionada.totalCompra.ToString();
                }
            }

            //evento quando clicasse no botao apagar linha
            private void buttonApagarLinhaCompra_Click(object sender, EventArgs e)
            {
                int index = listBoxLinhasCompra.SelectedIndex;
                int valor = Int32.Parse(textBoxValor.Text); //passa text para inteiro
                string descricao = textBoxDescricao.Text;
                Cliente clienteSelecionadao = (Cliente)listBoxCliente.SelectedItem;
                Compra compraSelecionada = (Compra)listBoxCompra.SelectedItem;
                Item itemSelecionado = (Item)listBoxLinhasCompra.SelectedItem;

                //verifica se tem compra selecionado
                if (itemSelecionado == null)
                {
                    MessageBox.Show("Selecione um item antes de apaga-lo");
                }
                else
                {
                    //remove um item 
                    compraSelecionada.removeItem(itemSelecionado);
                    atualizarItens();
                    atualizarCompras();
                    
                    //atualiza o selectedIndex
                    listBoxLinhasCompra.SelectedIndex = index - 1;

                    //mostra na label o valor das linhas
                    labelTotalLinhaDeCompra.Text = compraSelecionada.totalCompra.ToString();
                    
                    labelTotal.Text =clienteSelecionadao.total.ToString();
                }
            }
            
            //Funções auxiliares
            private void atualizarCompras()
            {
                Cliente clienteSelecionado = (Cliente)listBoxCliente.SelectedItem;

                //atuaiza a listBoxCompra
                listBoxCompra.DataSource = null;
                listBoxCompra.DataSource = clienteSelecionado.compras;
            }
            private void atualizarItens()
            {
                Compra compraSelecionada = (Compra)listBoxCompra.SelectedItem;

                //atualiza a listBoxLinhasCompra
                listBoxLinhasCompra.DataSource = null;
                listBoxLinhasCompra.DataSource = compraSelecionada.itens;
            }
        }
    }