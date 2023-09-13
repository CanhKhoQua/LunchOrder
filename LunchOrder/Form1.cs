using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        double subtotal;
        double ordertotal;
        int checkedCount = 0;
        double tax;
        public Form1()
        {
            InitializeComponent();
        }
        //Loc Nguyen

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Loc Nguyen

        private void ClearTotals()
        {
            txtOrderTotal.Clear();
            txtSalesTax.Clear();
            txtSubtotal.Clear();
            subtotal = 0;
            checkedCount = 0;
        }
        //Loc Nguyen

        private void ClearAddOns()
        {
            checkVeg.Checked = false;
            checkFries.Checked = false;
            checkSauce.Checked = false;
            subtotal = 0;
            checkedCount = 0;
        }
        //Loc Nguyen

        private void rdbBurger_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();
        }
        //Loc Nguyen

        private void rdnPizza_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();
        }
        //Loc Nguyen

        private void rdbSalad_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();
        }
        //Loc Nguyen

        private void checkVeg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVeg.Checked)
            {
                checkedCount++;
            }
            else
            {
                checkedCount--;
            }
        }
        //Loc Nguyen

        private void checkSauce_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSauce.Checked)
            {
                checkedCount++;
            }
            else
            {
                checkedCount--;
            }
        }
        //Loc Nguyen

        private void checkFries_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFries.Checked)
            {
                checkedCount++;
            }
            else
            {
                checkedCount--;
            }
        }
        //Loc Nguyen
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (rdbBurger.Checked)
            {
                subtotal = 6.95 + checkedCount * .75;
                tax = Math.Round(subtotal * 0.075, 2);
                ordertotal = Math.Round(subtotal + tax, 2);
                txtSubtotal.Text = subtotal.ToString();
                txtSalesTax.Text = tax.ToString();
                txtOrderTotal.Text = ordertotal.ToString();
            }
            else if (rdbPizza.Checked)
            {
                subtotal = 5.95 + checkedCount * .75;
                tax = Math.Round(subtotal * 0.075, 2);
                ordertotal = Math.Round(subtotal + tax, 2);
                txtSalesTax.Text = tax.ToString();
                txtSubtotal.Text = subtotal.ToString();
                txtOrderTotal.Text = ordertotal.ToString();
            }
            else
            {
                subtotal = 4.95 + checkedCount * .75;
                tax = Math.Round(subtotal * 0.075, 2);
                ordertotal = Math.Round(subtotal + tax, 2);
                txtSubtotal.Text = subtotal.ToString();
                txtSalesTax.Text = tax.ToString();
                txtOrderTotal.Text = ordertotal.ToString();
            }

        }


    }
}
