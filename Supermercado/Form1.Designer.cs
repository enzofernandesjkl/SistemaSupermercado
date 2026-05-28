namespace Supermercado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblCategoria = new Label();
            txtQuantidade = new TextBox();
            cmbCategoria = new ComboBox();
            lblQuantidade = new Label();
            lblPreco = new Label();
            txtPreco = new TextBox();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            dgvProdutos = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Location = new Point(12, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            lblNome.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(101, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(201, 23);
            txtNome.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.Location = new Point(12, 94);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 23);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(101, 152);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(201, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Alimentos", "Bebidas", "Limpeza", "Higiene", "Eletrônicos" });
            cmbCategoria.Location = new Point(101, 91);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(201, 23);
            cmbCategoria.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            lblQuantidade.Location = new Point(12, 155);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(83, 23);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            lblPreco.Location = new Point(12, 216);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(83, 23);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(101, 216);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(201, 23);
            txtPreco.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 293);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(116, 38);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button1_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(285, 293);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(117, 38);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(149, 293);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(121, 38);
            btnAtualizar.TabIndex = 11;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(12, 355);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(513, 424);
            dgvProdutos.TabIndex = 12;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(414, 293);
            button1.Name = "button1";
            button1.Size = new Size(111, 38);
            button1.TabIndex = 13;
            button1.Text = "Nova Compra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 791);
            Controls.Add(button1);
            Controls.Add(dgvProdutos);
            Controls.Add(btnAtualizar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(lblQuantidade);
            Controls.Add(cmbCategoria);
            Controls.Add(txtQuantidade);
            Controls.Add(lblCategoria);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCategoria;
        private TextBox txtQuantidade;
        private ComboBox cmbCategoria;
        private Label lblQuantidade;
        private Label lblPreco;
        private TextBox txtPreco;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private DataGridView dgvProdutos;
        private Button button1;
    }
}
