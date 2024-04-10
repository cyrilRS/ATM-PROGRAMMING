namespace atm
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

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form5 newForm5 = new Form5();
            newForm5.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form2 form4 = new Form2();
            this.Hide();
            form4.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form6 newForm6 = new Form6();
            newForm6.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
    }
}
