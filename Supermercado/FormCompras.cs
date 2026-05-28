using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Supermercado
{

    public partial class FormCompras : Form
    {
        List<ItemCompra> carrinho = new List<ItemCompra>();
        public List<Produto> listaProdutos;
        public FormCompras()
        {
            InitializeComponent();
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {

            {
                dgvLista.DataSource = listaProdutos;

                cmbProdutos.DataSource = listaProdutos;
                cmbProdutos.DisplayMember = "Nome";
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            {
                Produto selecionado = (Produto)cmbProdutos.SelectedItem;

                ItemCompra item = new ItemCompra();
                item.Nome = selecionado.Nome;
                item.Preco = selecionado.Preco;
                item.Quantidade = int.Parse(txtQtd.Text);

                carrinho.Add(item);

                AtualizarCarrinho();
            }
        }
        private void AtualizarCarrinho()
        {
            lstCarrinho.Items.Clear();

            decimal total = 0;

            foreach (var item in carrinho)
            {
                lstCarrinho.Items.Add($"{item.Nome} - {item.Quantidade} x {item.Preco} = {item.Total}");
                total += item.Total;
            }

            lblTotal.Text = "Total: R$ " + total.ToString("F2");
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
           
        {
            FormNota nota = new FormNota();

            nota.carrinho = carrinho;

            nota.Show();
        }
            {
                MessageBox.Show("Compra finalizada!");
            }
        }

        private void lblCarrinho_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
