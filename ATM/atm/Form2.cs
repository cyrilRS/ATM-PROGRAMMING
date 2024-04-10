using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace atm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0000")
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
                textbox.Clear(); // Clear the TextBox for another try
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
