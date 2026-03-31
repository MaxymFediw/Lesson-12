using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_12
{
    public partial class Lesson12 : Form
    {
        public Lesson12()
        {
            InitializeComponent();
        }

        private void btnFinalPrice_Click(object sender, EventArgs e)
        {
            string item;

            int quantity;

            double price, totalPrice;

            item = txtItem.Text;

            price = Convert.ToDouble(txtPrice.Text);
            quantity = Convert.ToInt32(txtQuantity.Text);

            totalPrice = (price * quantity) * 1.13;

            //lblTotalPrice.Text = "Final Price for " + quantity + " " + item + "(s) is: $" + totalPrice.ToString("C"); ;

            if (quantity >= 0 && totalPrice >= 0)
            {
                lblTotalPrice.Text = "Final Price for " + quantity + " " + item + "(s) is: " + totalPrice.ToString("C");
            }

            else 
            {
                lblTotalPrice.Text = "Invalid Numeric Values";
            }
        }
    }
}
