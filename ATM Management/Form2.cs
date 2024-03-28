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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            // Check if the input number is "0000"
            if (cardtext.Text == "0000")
            {
                // Navigate to Form3
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide(); // Hide Form2
            }
            else
            {
                // Stay on Form2
                MessageBox.Show("Incorrect card number. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cardtext.Clear(); // Clear the TextBox for another try
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
