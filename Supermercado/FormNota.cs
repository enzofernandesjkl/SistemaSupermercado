using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class FormNota : Form
    {
        public List<ItemCompra> carrinho;

        public FormNota()
        {
            InitializeComponent();
        }

        private void FormNota_Load(object sender, EventArgs e)
        {
         
        {
            StringBuilder nota = new StringBuilder();

            nota.AppendLine("SUPERMERCADO ENZO");
            nota.AppendLine("Data: " + DateTime.Now);
            nota.AppendLine("----------------------------");

            decimal total = 0;

            foreach (var item in carrinho)
            {
                nota.AppendLine($"{item.Nome} - {item.Quantidade} x {item.Preco} = {item.Total}");
                total += item.Total;
            }

            nota.AppendLine("----------------------------");
            nota.AppendLine("TOTAL: R$ " + total.ToString("F2"));

            txtNota.Text = nota.ToString();
        }

        }
    }
}
