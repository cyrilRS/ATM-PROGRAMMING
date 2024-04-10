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
    public partial class Form7 : Form
    {
        private decimal balance = 10000;
        public Form7()
        {
            InitializeComponent();
            UpdateBalanceLabel();
        }

        private void UpdateBalanceLabel()
        {
            lblBalance.Text = $"Your Current Balance is: ${balance}";
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Form4 form3 = new Form4();
            this.Hide();
            form3.ShowDialog();
        }
    }
}
