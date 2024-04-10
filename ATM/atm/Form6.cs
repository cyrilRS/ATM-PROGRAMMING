using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class Form6 : Form
    {
        private decimal balance = 10000;
        public Form6()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDepositAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the deposited amount is greater than zero
            if (amount <= 0)
            {
                MessageBox.Show("Deposit amount must be greater than zero.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform deposit
            balance += amount;
            MessageBox.Show($"Deposit successful. New balance: ${balance}", "Deposit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();

            // Open the login form (assuming your login form is named LoginForm)
            Form4 form3 = new Form4();
            form3.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form4 form3 = new Form4();
            this.Hide();
            form3.ShowDialog();
        }
    }
}
