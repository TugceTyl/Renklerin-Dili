namespace Renklerin_Dili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "y�netici" && textBox2.Text == "12345")
            {
                Form2 renkformu = new Form2();
                renkformu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanl�� Giri� Yapt�n�z Yeniden Deneyin!!!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}