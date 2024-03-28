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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            if (pintext.Text == "010101")
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Incorrect Pin code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pintext.Clear(); 
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }
    }
}
