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
    public partial class Form7 : Form
    {
        private Form4 form3Ref;
        public Form7(Form4 form3)
        {
            InitializeComponent();
            form3Ref = form3;
        }

        private void okay_Click(object sender, EventArgs e)
        {
            decimal depositAmount;

            if (decimal.TryParse(Deposittxt.Text, out depositAmount) && depositAmount > 0)
            {
                if (!(Deposittxt.Text.StartsWith("0") && Deposittxt.Text.Length > 1))
                {
                    form3Ref.UpdateBalance(depositAmount);
                    MessageBox.Show($"Deposit successful.");
                    Form4 form3 = new Form4();
                    this.Hide();
                    form3.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid deposit amount. Please enter a valid amount.");
                }
            }
            else
            {
                MessageBox.Show("Invalid deposit amount. Please enter a valid amount.");
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
