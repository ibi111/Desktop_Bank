namespace WinFormsApp1_bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup sign = new signup();
            this.Hide();
            sign.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();

            log.Show();
        
        }
    }
}