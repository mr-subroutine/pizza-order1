using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderApp1
{
    public partial class Form1 : Form
    {
        protected double smallSize = 3.00;
        protected double mediumSize = 4.00;
        protected double largeSize = 5.00;

        protected double cheese = 2.00;
        protected double pepperCheese = 4.00;
        protected double hawaiiCheese = 5.00;
        protected double supremeCheese = 6.00;

        protected double olives = 1.00;
        protected double gPepper = 1.00;
        protected double anchovies = 3.00;
        protected double pineapple = 1.00;
        protected double pinenuts = 1.00;
        protected double chicken = 6.00;
        protected double beef = 6.00;

        // totals up only after all radials completed
        protected double radial1CheckedTotal;
        protected double radial2CheckedTotal;
        protected double radial3CheckedTotal;
        protected double mainTotal = 0.00;

        // checks radial if filled so that the price can then be added
        protected bool sizeCheck = false;
        protected bool typeCheck = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void txtbox_price_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clearSizeCheck();
            if (radioButton1.Checked == true)
            {
                updateRadialChecked1(smallSize);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clearSizeCheck();
            if (radioButton2.Checked == true)
            {
                updateRadialChecked1(mediumSize);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            clearSizeCheck();
            if (radioButton3.Checked == true)
            {
                updateRadialChecked1(largeSize);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                updateRadialChecked2(cheese);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        // clear total upon each time a new radial is selected or it would add to the sum over and over.
        private void clearSizeCheck()
        {
            radial1CheckedTotal = 0;
        }

        // Update Radial Checked Chosen Size Price Box
        private void updateRadialChecked1(double pSize)
        {
            this.mainTotal += pSize;
            txtbox_price.Text = radial1CheckedTotal.ToString("C");

            // acknowledgement that radial section1 has been marked by user.
            sizeCheck = true;
        }

        private void updateRadialChecked2(double pType)
        {
            mainTotal = radial2CheckedTotal + pType;
            txtbox_price.Text = radial2CheckedTotal.ToString("C");

            // acknowledgement that radial section2 has been marked by user.
            sizeCheck = true;
        }


        // Clear Order Button
        private void button1_Click(object sender, EventArgs e)
        {
            txtbox_price.Clear();
            sizeCheck = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
