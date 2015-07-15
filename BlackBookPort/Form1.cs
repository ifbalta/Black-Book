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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void saveProduct(object sender, EventArgs e)
        {

            Product product = new Product(txtID.Text,
                txtName.Text, txtDescription.Text, 
                comboCategory.Text, Double.Parse(txtPrice.Text), 
                 int.Parse(txtQuantity.Text));
            Console.WriteLine(product);
        }
    }
}
