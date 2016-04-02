/****    
*
* Name: Russell Walton
* Student Number: T00249622
* Seminar Number: 5
* Due Date:  Mar.3, 2015
*
* Program Purpose: Create an application that has 2 list boxes, ones for hours worked and one
 * for rate of pay. Compute basic pay, overtime pay, gross pay, tax deducted, and net pay.
 * Write atleast 3 user defined methods.
*
****/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar5_Problem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int h;
            decimal payRate;

            for (h = 35; h <= 45; h++)
            {
                hoursListBox.Items.Add(h);
            }

            for (payRate = 9.50m; payRate <= 14.00m; payRate += 0.50m)
            {
                payListBox.Items.Add(payRate);
            }
        }

        private decimal calcBasicPay(int hours, decimal rate)
        {
            int basicHours;

            if (hours > 40)
            {
                basicHours = 40;
            }

            else
                basicHours = hours;

            return basicHours * rate;
        }

        private decimal calcOTPay(int hours, decimal rate)
        {
            int otHours;

            if (hours > 40)
            {
                otHours = hours - 40;
            }

            else
                otHours = 0;

            return otHours * (1.50m * rate);
        }

        private decimal calcGrossPay(decimal basic, decimal ot)
        {
            return basic + ot;
        }

        private decimal taxDeduct(decimal gross)
        {
            decimal tax;

            if (gross > 450.00m)
                tax = gross * 0.20m;
            else if (gross >= 350.00m)
                tax = gross * 0.15m;
            else
                tax = gross * 0.10m;

            return tax;
        }

        private decimal calcNetPay(decimal gross, decimal tax)
        {
            return gross - tax;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            decimal basic, ot, gross, tax, net;
            int hours = int.Parse(hoursListBox.SelectedItem.ToString());
            decimal rate = decimal.Parse(payListBox.SelectedItem.ToString());

            basic = calcBasicPay(hours, rate);
            ot = calcOTPay(hours, rate);
            gross = calcGrossPay(basic, ot);
            tax = taxDeduct(gross);
            net = calcNetPay(gross, tax);

            basicTextBox.Text = basic.ToString("c");
            otTextBox.Text = ot.ToString("c");
            grossTextBox.Text = gross.ToString("c");
            taxTextBox.Text = tax.ToString("c");
            netTextBox.Text = net.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            basicTextBox.Text = "";
            otTextBox.Text = "";
            grossTextBox.Text =  "";
            taxTextBox.Text = "";
            netTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
