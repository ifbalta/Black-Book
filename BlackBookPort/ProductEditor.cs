using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBookPort
{
    public partial class ProductEditor : Form
    {
        public ProductEditor()
        {
            InitializeComponent();
        }



        private void saveProduct(object sender, EventArgs e)
        {

            Product product = new Product();
            product.ID = txtID.Text;
            product.Name = txtName.Text;
            product.Description = txtDescription.Text;
            product.Category = comboCategory.Text;
            product.Price = Double.Parse(txtPrice.Text);
            product.Quantity = int.Parse(txtQuantity.Text);
            Console.WriteLine(product);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
