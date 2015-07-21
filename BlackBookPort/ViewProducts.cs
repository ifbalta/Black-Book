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
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var message = "Are you sure you want to delete that?";
            var title = "Delete Product";
            var result = MessageBox.Show(
                message,                  // the message to show
                title,                    // the title for the dialog box
                MessageBoxButtons.YesNo,  // show two buttons: Yes and No
                MessageBoxIcon.Question); // show a question mark icon

            // the following can be handled as if/else statements as well
            switch (result)
            {
                case DialogResult.Yes:   // Yes button pressed
                    MessageBox.Show("Deleting product...");
                    break;
                case DialogResult.No:    // No button pressed
                    MessageBox.Show("Whew!");
                    break;
                default:                 // Neither Yes nor No pressed (just in case)
                    MessageBox.Show("What did you press?");
                    break;
            }
        }



          
    }
}
