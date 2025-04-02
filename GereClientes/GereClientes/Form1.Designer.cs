namespace GereClientes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNif = new System.Windows.Forms.TextBox();
            this.buttonAdicionarCliente = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelNif = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonCriarCompra = new System.Windows.Forms.Button();
            this.buttonApagarCompra = new System.Windows.Forms.Button();
            this.labelTotalLinhaDeCompra = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonApagarLinhaCompra = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonAdicionarLinha = new System.Windows.Forms.Button();
            this.listBoxCliente = new System.Windows.Forms.ListBox();
            this.listBoxCompra = new System.Windows.Forms.ListBox();
            this.listBoxLinhasCompra = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserir Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "NIF:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(175, 103);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(180, 22);
            this.textBoxNome.TabIndex = 5;
            this.textBoxNome.Text = "Paulo Pinto";
            // 
            // textBoxNif
            // 
            this.textBoxNif.Location = new System.Drawing.Point(175, 143);
            this.textBoxNif.Name = "textBoxNif";
            this.textBoxNif.Size = new System.Drawing.Size(180, 22);
            this.textBoxNif.TabIndex = 6;
            this.textBoxNif.Text = "271459077";
            // 
            // buttonAdicionarCliente
            // 
            this.buttonAdicionarCliente.Location = new System.Drawing.Point(280, 171);
            this.buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            this.buttonAdicionarCliente.Size = new System.Drawing.Size(75, 27);
            this.buttonAdicionarCliente.TabIndex = 7;
            this.buttonAdicionarCliente.Text = "Adicionar";
            this.buttonAdicionarCliente.UseVisualStyleBackColor = true;
            this.buttonAdicionarCliente.Click += new System.EventHandler(this.buttonAdicionarCliente_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(417, 97);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(142, 25);
            this.labelNome.TabIndex = 9;
            this.labelNome.Text = "Nome Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(466, 176);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(14, 16);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "0";
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNif.Location = new System.Drawing.Point(420, 137);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(107, 25);
            this.labelNif.TabIndex = 12;
            this.labelNif.Text = "Nif cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Compras";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(419, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Compras:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(612, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Linhas de compras:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(596, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Adicionar linha de compras:";
            // 
            // buttonCriarCompra
            // 
            this.buttonCriarCompra.Location = new System.Drawing.Point(422, 483);
            this.buttonCriarCompra.Name = "buttonCriarCompra";
            this.buttonCriarCompra.Size = new System.Drawing.Size(75, 54);
            this.buttonCriarCompra.TabIndex = 19;
            this.buttonCriarCompra.Text = "Criar compra";
            this.buttonCriarCompra.UseVisualStyleBackColor = true;
            this.buttonCriarCompra.Click += new System.EventHandler(this.buttonCriarCompra_Click);
            // 
            // buttonApagarCompra
            // 
            this.buttonApagarCompra.Location = new System.Drawing.Point(511, 483);
            this.buttonApagarCompra.Name = "buttonApagarCompra";
            this.buttonApagarCompra.Size = new System.Drawing.Size(75, 54);
            this.buttonApagarCompra.TabIndex = 20;
            this.buttonApagarCompra.Text = "Apagar";
            this.buttonApagarCompra.UseVisualStyleBackColor = true;
            this.buttonApagarCompra.Click += new System.EventHandler(this.buttonApagarCompra_Click);
            // 
            // labelTotalLinhaDeCompra
            // 
            this.labelTotalLinhaDeCompra.AutoSize = true;
            this.labelTotalLinhaDeCompra.Location = new System.Drawing.Point(659, 502);
            this.labelTotalLinhaDeCompra.Name = "labelTotalLinhaDeCompra";
            this.labelTotalLinhaDeCompra.Size = new System.Drawing.Size(14, 16);
            this.labelTotalLinhaDeCompra.TabIndex = 22;
            this.labelTotalLinhaDeCompra.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(612, 502);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "Total:";
            // 
            // buttonApagarLinhaCompra
            // 
            this.buttonApagarLinhaCompra.Location = new System.Drawing.Point(694, 483);
            this.buttonApagarLinhaCompra.Name = "buttonApagarLinhaCompra";
            this.buttonApagarLinhaCompra.Size = new System.Drawing.Size(75, 54);
            this.buttonApagarLinhaCompra.TabIndex = 23;
            this.buttonApagarLinhaCompra.Text = "Apagar";
            this.buttonApagarLinhaCompra.UseVisualStyleBackColor = true;
            this.buttonApagarLinhaCompra.Click += new System.EventHandler(this.buttonApagarLinhaCompra_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(604, 160);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(173, 22);
            this.textBoxValor.TabIndex = 27;
            this.textBoxValor.Text = "5";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(604, 116);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(173, 22);
            this.textBoxDescricao.TabIndex = 26;
            this.textBoxDescricao.Text = "Peixe";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(601, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "Valor:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(601, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "Descrição:";
            // 
            // buttonAdicionarLinha
            // 
            this.buttonAdicionarLinha.Location = new System.Drawing.Point(604, 188);
            this.buttonAdicionarLinha.Name = "buttonAdicionarLinha";
            this.buttonAdicionarLinha.Size = new System.Drawing.Size(173, 27);
            this.buttonAdicionarLinha.TabIndex = 28;
            this.buttonAdicionarLinha.Text = "Adicionar linha";
            this.buttonAdicionarLinha.UseVisualStyleBackColor = true;
            this.buttonAdicionarLinha.Click += new System.EventHandler(this.buttonAdicionarLinha_Click);
            // 
            // listBoxCliente
            // 
            this.listBoxCliente.FormattingEnabled = true;
            this.listBoxCliente.ItemHeight = 16;
            this.listBoxCliente.Location = new System.Drawing.Point(102, 281);
            this.listBoxCliente.Name = "listBoxCliente";
            this.listBoxCliente.Size = new System.Drawing.Size(253, 196);
            this.listBoxCliente.TabIndex = 29;
            this.listBoxCliente.SelectedIndexChanged += new System.EventHandler(this.listBoxCliente_SelectedIndexChanged);
            // 
            // listBoxCompra
            // 
            this.listBoxCompra.FormattingEnabled = true;
            this.listBoxCompra.ItemHeight = 16;
            this.listBoxCompra.Location = new System.Drawing.Point(422, 297);
            this.listBoxCompra.Name = "listBoxCompra";
            this.listBoxCompra.Size = new System.Drawing.Size(164, 180);
            this.listBoxCompra.TabIndex = 30;
            this.listBoxCompra.SelectedIndexChanged += new System.EventHandler(this.listBoxCompra_SelectedIndexChanged_1);
            // 
            // listBoxLinhasCompra
            // 
            this.listBoxLinhasCompra.FormattingEnabled = true;
            this.listBoxLinhasCompra.ItemHeight = 16;
            this.listBoxLinhasCompra.Location = new System.Drawing.Point(615, 297);
            this.listBoxLinhasCompra.Name = "listBoxLinhasCompra";
            this.listBoxLinhasCompra.Size = new System.Drawing.Size(164, 180);
            this.listBoxLinhasCompra.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 557);
            this.Controls.Add(this.listBoxLinhasCompra);
            this.Controls.Add(this.listBoxCompra);
            this.Controls.Add(this.listBoxCliente);
            this.Controls.Add(this.buttonAdicionarLinha);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.buttonApagarLinhaCompra);
            this.Controls.Add(this.labelTotalLinhaDeCompra);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonApagarCompra);
            this.Controls.Add(this.buttonCriarCompra);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelNif);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonAdicionarCliente);
            this.Controls.Add(this.textBoxNif);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNif;
        private System.Windows.Forms.Button buttonAdicionarCliente;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelNif;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonCriarCompra;
        private System.Windows.Forms.Button buttonApagarCompra;
        private System.Windows.Forms.Label labelTotalLinhaDeCompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonApagarLinhaCompra;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonAdicionarLinha;
        private System.Windows.Forms.ListBox listBoxCliente;
        private System.Windows.Forms.ListBox listBoxCompra;
        private System.Windows.Forms.ListBox listBoxLinhasCompra;
    }
}

