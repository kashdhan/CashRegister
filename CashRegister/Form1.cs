using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{//Kashish Dhanoa
 //November 26 2020
 //A candy store's simple cash register with a digital printed receipt.

    public partial class Form1 : Form
    {//global variables
        double chocolatePrice = 3.00;
        double lollipopPrice = 1.50;
        double gummyPrice = 2.50;

        double numberChocolate;
        double numberLollipop;
        double numberGummy;

        double hst = 0.13;
        double subtotal;
        double taxOfOrder;
        double total;

        double paidCash;
        double change;
        public Form1()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {//calculate subtotal, tax and total of requested amounts of candy
            try
            {
                //convert customer inputs into compatabile integers 
                numberChocolate = Convert.ToInt32(chocolateInput.Text);
                numberLollipop = Convert.ToInt32(lollipopInput.Text);
                numberGummy = Convert.ToInt32(gummyInput.Text);

                //subtotal, tax and total formulas 
                subtotal = numberChocolate * chocolatePrice + numberLollipop * lollipopPrice + numberGummy * gummyPrice;
                taxOfOrder = hst * subtotal;
                total = subtotal + taxOfOrder;

                //label displays subtotal, tax and total
                subtotalLabel.Text += $"                  {subtotal.ToString("C")}";
                taxLabel.Text += $"                       {taxOfOrder.ToString("C")}";
                totalLabel.Text += $"                     {total.ToString("C")}";

                //clear error label if corrections are made
                errorLabel.Text = "";
            }
            catch
            {
                //error label text
                errorLabel.Text = $"ERROR: only use numerical values";
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {//calculate change from tenderInput
            try
            {
                //convert customer tender input into compatable double values
                paidCash = Convert.ToDouble(tenderInput.Text);

                //change formula 
                change = paidCash - total;

                //label displays the amount of change 
                changeLabel.Text += $"                   {change.ToString("C")}";

                //clear error labe if corrections are made
                errorLabel.Text = "";
            }
            catch
            {
                //error label text
                errorLabel.Text = $"ERROR: only use numerical values";
            }
        }

        private void RecieptButton_Click(object sender, EventArgs e)
        {//reciept "print" out with sounds containing whole transaction 

            //sound plays when displaying the name of the company
            SoundPlayer player1 = new SoundPlayer(Properties.Resources.registereffect1);
            player1.Play();
            outputLabel.Text = $"Candy Corner Corp.";
            Refresh();
            Thread.Sleep(500);
            player1.Stop();

            //sound plays when displaying an order number
            player1.Play();
            outputLabel.Text += $"\n\nOrder Number 500765";
            Refresh();
            Thread.Sleep(500);
            player1.Stop();

            //sound plays when displaying the date
            player1.Play();
            outputLabel.Text += $"\n2020-11-26";
            Refresh();
            Thread.Sleep(500);
            player1.Stop();

            //sound plays when displaying the price and amount of chocolate bars 
            player1.Play();
            outputLabel.Text += $"\n\nChocolate Bars    x{numberChocolate}   @{chocolatePrice.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            player1.Stop();

            //sound plays when displaying the price and amount of lollipops
            player1.Play();
            outputLabel.Text += $"\nLollipops         x{numberLollipop}   @{lollipopPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            player1.Stop();

            //sound plays when displaying the price and amount gummy packets 
            player1.Play();
            outputLabel.Text += $"\nGummy Packets     x{numberGummy}   @{gummyPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            player1.Stop();

            //sound plays when displaying the subtotal value
            player1.Play();
            outputLabel.Text += $"\n\nSubtotal                {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            player1.Stop();

            //sound plays when displaying the tax value
            player1.Play();
            outputLabel.Text += $"\nTax                     {taxOfOrder.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            player1.Stop();

            //sound plays when displaying the total cost of the transaction
            player1.Play();
            outputLabel.Text += $"\n\nTotal                   {total.ToString("C")}";
            Refresh();
            Thread.Sleep(500);
            player1.Stop();

            //sound plays when displaying the amount of cash given 
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.cashreg);
            player2.Play();
            outputLabel.Text += $"\n\nTendered                {paidCash.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            //sound plays when displaying the amount of change 
            outputLabel.Text += $"\nChange                  {change.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            //"thank you" text on receipt 
            outputLabel.Text += $"\n\nThank you for shopping at Candy Corner. We appreciate your business and hope to see you soon!";
            Refresh();
            Thread.Sleep(500);
        }
        private void NewOrderButton_Click(object sender, EventArgs e)
        {//resets all values to original values
            chocolateInput.Text = "0";
            lollipopInput.Text = "0";
            gummyInput.Text = "0";
            tenderInput.Text = "0";

            outputLabel.Text = "";
            errorLabel.Text = "";

            subtotalLabel.Text = $"Subtotal:";
            taxLabel.Text = $"Tax:";
            totalLabel.Text = $"Total:";
            changeLabel.Text = $"Change:";

            numberChocolate = 0;
            numberLollipop = 0;
            numberGummy = 0;
            subtotal = 0;
            total = 0;
            hst = 0.13;
            taxOfOrder = 0;
            change = 0;
            paidCash = 0;


        }
    }
}


