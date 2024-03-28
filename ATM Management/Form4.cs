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
    public partial class Form4 : Form
    {

        private static decimal balance = 10000;
        public Form4()
        {
            InitializeComponent();
        }
        public decimal Balance
        {
            get { return balance; }
        }

        public void UpdateBalance(decimal amount)
        {
            balance += amount;
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5(this);
            this.Hide();
            newForm.ShowDialog();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7(this);
            this.Hide();
            newForm.ShowDialog();
        }

        private void checkbalance_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6(this);
            this.Hide();
            newForm.ShowDialog();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Form2 form4 = new Form2();
            this.Hide();
            form4.ShowDialog();
        }
    }
}
