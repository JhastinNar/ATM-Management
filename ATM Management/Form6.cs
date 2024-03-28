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
    public partial class Form6 : Form
    {
        private Form4 form3Ref;
        public Form6(Form4 form3)
        {
            InitializeComponent();
            form3Ref = form3;
            DisplayBalance();
        }
        private void DisplayBalance()
        {
            balancelabel.Text = $"Balance: {form3Ref.Balance:C}";
        }

        private void okay_Click(object sender, EventArgs e)
        {
            Form4 form3 = new Form4();
            this.Hide();
            form3.ShowDialog();
        }
    }
}
