using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_05
{
    public partial class FormIceCreamShop : Form
    {
        public FormIceCreamShop()
        {
            InitializeComponent();
        }
        /// <summary>
        /// totals up all of the values in the list box and displays them in the labelShowPrice label
        /// and also writes a record of the order to Records.txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTotalPrice_Click(object sender, EventArgs e)
        {
            decimal total = 0.00M;
            foreach (decimal item in listBoxConeOrders.Items)
            {
                total += item;
            }
            //Appends info about the time of the order and the total of the order to Records.txt
            StreamWriter writer = new StreamWriter("Records.txt", true);
            labelShowPrice.Text = "$" + total;
            string record = System.DateTime.Now.ToString() + " Total: " + total;
            writer.WriteLine(record);
            writer.Flush();
            writer.Close();
        }
        /// <summary>
        /// Adds an ice cream order to based on the flavor and toppings selected and 
        /// displays it in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            //set prices for the flavors
            const decimal CHOCOLATE_PRICE = 4.00M;
            const decimal VANILLA_PRICE = 3.00M;
            const decimal STRAWBERRY_PRICE = 5.00M;
            //set prices for the toppings
            const decimal SPRINKLES_PRICE = 1.00M;
            const decimal MIXED_NUTS_PRICE = 3.00M;
            const decimal CHERRY_PRICE = 2.00M;
            //Total price variable
            decimal totalPrice = 0.00M;

            if (radioButtonChocolate.Checked)
            {
                totalPrice = CHOCOLATE_PRICE;
            }
            if (radioButtonVanilla.Checked)
            {
                totalPrice = VANILLA_PRICE;
            }
            if (radioButtonStrawberry.Checked)
            {
                totalPrice = STRAWBERRY_PRICE;
            }

            if (checkBoxSprinkles.Checked)
            {
                totalPrice += SPRINKLES_PRICE;
            }
            if (checkBoxChoppedNuts.Checked)
            {
                totalPrice += MIXED_NUTS_PRICE;
            }
            if (checkBoxCherry.Checked)
            {
                totalPrice += CHERRY_PRICE;
            }
            //Displays the price in the list box
            listBoxConeOrders.Items.Add(totalPrice);

            //Clears the checkboxes after the item is added
            checkBoxCherry.Checked = false;
            checkBoxChoppedNuts.Checked = false;
            checkBoxSprinkles.Checked = false;

            //Returns Chocolate to being the default selected radio button
            radioButtonChocolate.Checked = true;
        }
        /// <summary>
        /// Resets the state of all the interactable items in the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearOrders_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            listBoxConeOrders.Items.Clear();

            //Clears the checkboxes
            checkBoxCherry.Checked = false;
            checkBoxChoppedNuts.Checked = false;
            checkBoxSprinkles.Checked = false;

            //Returns Chocolate to being the default selected radio button
            radioButtonChocolate.Checked = true;

            //Clears the text in the labelShowPrice label
            labelShowPrice.Text = "";
        }
    }
}
