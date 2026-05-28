namespace Supermercado
{
    partial class FormCompras
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
            dgvLista = new DataGridView();
            lblLista = new Label();
            lstCarrinho = new ListBox();
            lblCarrinho = new Label();
            cmbProdutos = new ComboBox();
            txtQtd = new TextBox();
            btnAdicionar = new Button();
            lblTotal = new Label();
            btnFinalizar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(12, 42);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(542, 454);
            dgvLista.TabIndex = 0;
            // 
            // lblLista
            // 
            lblLista.Location = new Point(12, 9);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(118, 23);
            lblLista.TabIndex = 1;
            lblLista.Text = "Lista de Produtos";
            // 
            // lstCarrinho
            // 
            lstCarrinho.FormattingEnabled = true;
            lstCarrinho.Location = new Point(595, 42);
            lstCarrinho.Name = "lstCarrinho";
            lstCarrinho.Size = new Size(299, 454);
            lstCarrinho.TabIndex = 2;
            // 
            // lblCarrinho
            // 
            lblCarrinho.Location = new Point(595, 9);
            lblCarrinho.Name = "lblCarrinho";
            lblCarrinho.Size = new Size(100, 23);
            lblCarrinho.TabIndex = 3;
            lblCarrinho.Text = "Carrinho";
            lblCarrinho.Click += lblCarrinho_Click;
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Items.AddRange(new object[] { "Alimentos", "Bebidas", "Limpeza", "Higiene", "Eletrônicos" });
            cmbProdutos.Location = new Point(12, 556);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(207, 23);
            cmbProdutos.TabIndex = 4;
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(12, 631);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(207, 23);
            txtQtd.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 689);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(207, 48);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(706, 545);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 34);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total: R$ 0,00";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(643, 583);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(219, 45);
            btnFinalizar.TabIndex = 8;
            btnFinalizar.Text = "Finalizar Compra";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 613);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 9;
            label1.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 538);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 10;
            label2.Text = "Escolher Produto:";
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 822);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFinalizar);
            Controls.Add(lblTotal);
            Controls.Add(btnAdicionar);
            Controls.Add(txtQtd);
            Controls.Add(cmbProdutos);
            Controls.Add(lblCarrinho);
            Controls.Add(lstCarrinho);
            Controls.Add(lblLista);
            Controls.Add(dgvLista);
            Name = "FormCompras";
            Text = "FormCompras";
            Load += FormCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLista;
        private Label lblLista;
        private ListBox lstCarrinho;
        private Label lblCarrinho;
        private ComboBox cmbProdutos;
        private TextBox txtQtd;
        private Button btnAdicionar;
        private Label lblTotal;
        private Button btnFinalizar;
        private Label label1;
        private Label label2;
    }
}