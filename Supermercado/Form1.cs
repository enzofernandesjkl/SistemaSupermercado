namespace Supermercado
{
    using System.Collections.Generic;
    public partial class Form1 : Form
    {
        List<Produto> listaProdutos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite o nome do produto");
                return;
            }

            Produto p = new Produto();

            p.Id = listaProdutos.Count + 1;
            p.Nome = txtNome.Text;
            p.Categoria = cmbCategoria.Text;
            p.Quantidade = int.Parse(txtQuantidade.Text);
            p.Preco = decimal.Parse(txtPreco.Text);

            listaProdutos.Add(p);

            AtualizarGrid();

            MessageBox.Show("Produto cadastrado!");

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaProdutos;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            {
                int id = int.Parse(dgvProdutos.CurrentRow.Cells["Id"].Value.ToString());

                foreach (var p in listaProdutos)
                {
                    if (p.Id == id)
                    {
                        p.Nome = txtNome.Text;
                        p.Categoria = cmbCategoria.Text;
                        p.Quantidade = int.Parse(txtQuantidade.Text);
                        p.Preco = decimal.Parse(txtPreco.Text);
                    }
                }

                AtualizarGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            {
                int id = int.Parse(dgvProdutos.CurrentRow.Cells["Id"].Value.ToString());

                listaProdutos.RemoveAll(p => p.Id == id);

                AtualizarGrid();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormCompras tela = new FormCompras();
            tela.listaProdutos = listaProdutos;
            tela.Show();
        }
    }
}
