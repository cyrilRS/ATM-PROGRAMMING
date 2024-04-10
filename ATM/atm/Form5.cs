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
    public partial class Form5 : Form
    {
        private decimal balance = 10000;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void txtWithdrawAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form4 form3 = new Form4();
            this.Hide();
            form3.ShowDialog();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtWithdrawAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the balance is sufficient for withdrawal
            if (amount <= 0)
            {
                MessageBox.Show("Withdrawal amount must be greater than zero.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amount > balance)
            {
                MessageBox.Show("Insufficient funds.", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            balance -= amount;
            MessageBox.Show($"Withdrawal successful. New balance: ${balance}", "Withdrawal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

            // Open the login form (assuming your login form is named LoginForm)
            Form4 form3 = new Form4();
            form3.Show();
        }
    }
}
