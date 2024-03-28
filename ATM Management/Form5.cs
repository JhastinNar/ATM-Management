using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management
{
    public partial class Form5 : Form
    {
        private Form4 form4Ref;
        public Form5(Form4 form4)
        {
            InitializeComponent();
            form4Ref = form4;
        }

        private void okay_Click(object sender, EventArgs e)
        {
            decimal withdrawalAmount;
            if (decimal.TryParse(Withdrawtxt.Text, out withdrawalAmount))
            {
                // Check if the amount is greater than 0
                if (withdrawalAmount > 0)
                {
                    // Check if the amount does not start with '0'
                    if (!(Withdrawtxt.Text.StartsWith("0") && Withdrawtxt.Text.Length > 1))
                    {
                        if (withdrawalAmount > form4Ref.Balance)
                        {
                            MessageBox.Show("You do not have enough balance to withdraw this amount.");
                        }
                        else
                        {
                            form4Ref.UpdateBalance(-withdrawalAmount);
                            MessageBox.Show($"Withdraw successful.");
                            Form4 form4 = new Form4();
                            this.Hide();
                            form4.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid withdrawal amount. Please enter a valid amount.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid withdrawal amount.");
                }
            }
            else
            {
                MessageBox.Show("Invalid withdrawal amount. Please enter a valid amount.");
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }
    }
}
