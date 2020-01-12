using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderSystem
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNoOfPizzas.Text = "";
        }

        double total = 0.0;
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(txtNoOfPizzas.Text);
            double charges = quantity * 150;            

            string pizzaName = "";

            //radio buttons
            if (rBtnMargarita.Checked)
            {
                pizzaName = rBtnMargarita.Text;
            }
            else if (rBtnHawaiian.Checked)
            {
                pizzaName = rBtnHawaiian.Text;
            }
            else if (rBtnMeatLovers.Checked)
            {
                pizzaName = rBtnMeatLovers.Text;
            }
            else if (rBtnSupreme.Checked)
            {
                pizzaName = rBtnSupreme.Text;
            }
            else if (rBtnVegetarian.Checked)
            {
                pizzaName = rBtnVegetarian.Text;
            }

            //checkboxes
            string toppings = "";
            if (cbOlives.Checked)
            {
                toppings = cbOlives.Text;
            }
            else if (cbMushrooms.Checked)
            {
                toppings = cbMushrooms.Text;
            }
            else if (cbExtraCheese.Checked)
            {
                toppings = cbExtraCheese.Text;
            }
            else if (cbChillies.Checked)
            {
                toppings = cbChillies.Text;
            }

            //int top = int.Parse(cbChillies.Text);
            //int top = Convert.ToInt32(cbChillies.Text); 
            double toppingsCharge = 2 * 10; 

            string shoppingCart = string.Format("{0} \t R 150.00 * {1} \n {2}", pizzaName, txtNoOfPizzas.Text, Convert.ToString(charges.ToString("C")));
            string shoppingCartToppings = string.Format("{0} \t {1}", toppings, Convert.ToInt32(toppingsCharge.ToString("C")));
            
            listBox1.Items.Add(shoppingCart);
            listBox1.Items.Add(shoppingCartToppings);
            
            //alternative
            /*getPizza(rBtnMargarita);
            getPizza(rBtnMeatLovers);
            getPizza(rBtnHawaiian);
            getPizza(rBtnSupreme);
            getPizza(rBtnVegetarian);*/
        }

        //alternative
        /*private void getPizza(RadioButton rdoButton)
        {
            if (rdoButton.Checked)
            {
                MessageBox.Show(rdoButton.Text);
            }
        }*/

    }
}
