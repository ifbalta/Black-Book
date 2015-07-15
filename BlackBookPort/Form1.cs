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
            String id = txtID.Text;
            String name = txtName.Text;
            String description = txtDescription.Text;
            String category = comboCategory.Text;
            Double price = Double.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);

            Product product = new Product(id, name, description, category, price, quantity);

            Console.WriteLine("id {0}\nname:{1}\ndescription:{1}", id, name, description);
            Console.WriteLine("price: {0}\nquantity:{1}\ncategory: {2}", price, quantity, category);
        }
    }
}
