namespace CRUD_CEP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label_Cep = new System.Windows.Forms.Label();
            this.Box_Cep = new System.Windows.Forms.TextBox();
            this.BoxLogradouro = new System.Windows.Forms.TextBox();
            this.label_logradouro = new System.Windows.Forms.Label();
            this.BoxNumero = new System.Windows.Forms.TextBox();
            this.label_numero = new System.Windows.Forms.Label();
            this.BoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.BoxUF = new System.Windows.Forms.TextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonExibir = new System.Windows.Forms.Button();
            this.buttonConsult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Cep
            // 
            this.Label_Cep.AutoSize = true;
            this.Label_Cep.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cep.Location = new System.Drawing.Point(21, 17);
            this.Label_Cep.Name = "Label_Cep";
            this.Label_Cep.Size = new System.Drawing.Size(58, 25);
            this.Label_Cep.TabIndex = 0;
            this.Label_Cep.Text = "CEP";
            this.Label_Cep.Click += new System.EventHandler(this.label1_Click);
            // 
            // Box_Cep
            // 
            this.Box_Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Cep.Location = new System.Drawing.Point(26, 41);
            this.Box_Cep.Name = "Box_Cep";
            this.Box_Cep.Size = new System.Drawing.Size(162, 26);
            this.Box_Cep.TabIndex = 1;
            // 
            // BoxLogradouro
            // 
            this.BoxLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLogradouro.Location = new System.Drawing.Point(26, 103);
            this.BoxLogradouro.Name = "BoxLogradouro";
            this.BoxLogradouro.Size = new System.Drawing.Size(512, 26);
            this.BoxLogradouro.TabIndex = 3;
            this.BoxLogradouro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_logradouro
            // 
            this.label_logradouro.AutoSize = true;
            this.label_logradouro.BackColor = System.Drawing.SystemColors.Control;
            this.label_logradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logradouro.Location = new System.Drawing.Point(21, 79);
            this.label_logradouro.Name = "label_logradouro";
            this.label_logradouro.Size = new System.Drawing.Size(132, 25);
            this.label_logradouro.TabIndex = 2;
            this.label_logradouro.Text = "Logradouro";
            this.label_logradouro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BoxNumero
            // 
            this.BoxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNumero.Location = new System.Drawing.Point(549, 103);
            this.BoxNumero.Name = "BoxNumero";
            this.BoxNumero.Size = new System.Drawing.Size(40, 26);
            this.BoxNumero.TabIndex = 5;
            this.BoxNumero.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_numero
            // 
            this.label_numero.AutoSize = true;
            this.label_numero.BackColor = System.Drawing.SystemColors.Control;
            this.label_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero.Location = new System.Drawing.Point(544, 79);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(37, 25);
            this.label_numero.TabIndex = 4;
            this.label_numero.Text = "Nº";
            this.label_numero.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // BoxCidade
            // 
            this.BoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxCidade.Location = new System.Drawing.Point(600, 103);
            this.BoxCidade.Name = "BoxCidade";
            this.BoxCidade.Size = new System.Drawing.Size(130, 26);
            this.BoxCidade.TabIndex = 7;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.BackColor = System.Drawing.SystemColors.Control;
            this.labelCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(595, 79);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(86, 25);
            this.labelCidade.TabIndex = 6;
            this.labelCidade.Text = "Cidade";
            // 
            // BoxUF
            // 
            this.BoxUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUF.Location = new System.Drawing.Point(739, 103);
            this.BoxUF.Name = "BoxUF";
            this.BoxUF.Size = new System.Drawing.Size(40, 26);
            this.BoxUF.TabIndex = 9;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.BackColor = System.Drawing.SystemColors.Control;
            this.labelUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUF.Location = new System.Drawing.Point(734, 79);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(42, 25);
            this.labelUF.TabIndex = 8;
            this.labelUF.Text = "UF";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 226);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(26, 385);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(90, 29);
            this.buttonInsert.TabIndex = 11;
            this.buttonInsert.Text = "Inserir";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(133, 385);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(90, 29);
            this.buttonAlterar.TabIndex = 12;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(241, 385);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(90, 29);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Excluir";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonExibir
            // 
            this.buttonExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExibir.Location = new System.Drawing.Point(443, 385);
            this.buttonExibir.Name = "buttonExibir";
            this.buttonExibir.Size = new System.Drawing.Size(90, 29);
            this.buttonExibir.TabIndex = 14;
            this.buttonExibir.Text = "Listar";
            this.buttonExibir.UseVisualStyleBackColor = true;
            // 
            // buttonConsult
            // 
            this.buttonConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsult.Location = new System.Drawing.Point(341, 385);
            this.buttonConsult.Name = "buttonConsult";
            this.buttonConsult.Size = new System.Drawing.Size(90, 29);
            this.buttonConsult.TabIndex = 15;
            this.buttonConsult.Text = "Consultar";
            this.buttonConsult.UseVisualStyleBackColor = true;
            this.buttonConsult.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConsult);
            this.Controls.Add(this.buttonExibir);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BoxUF);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.BoxCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.BoxNumero);
            this.Controls.Add(this.label_numero);
            this.Controls.Add(this.BoxLogradouro);
            this.Controls.Add(this.label_logradouro);
            this.Controls.Add(this.Box_Cep);
            this.Controls.Add(this.Label_Cep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cadastro Imoveis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Cep;
        private System.Windows.Forms.TextBox Box_Cep;
        private System.Windows.Forms.TextBox BoxLogradouro;
        private System.Windows.Forms.Label label_logradouro;
        private System.Windows.Forms.TextBox BoxNumero;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.TextBox BoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox BoxUF;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonExibir;
        private System.Windows.Forms.Button buttonConsult;
    }
}

