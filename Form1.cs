namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double plot = double.Parse(this.textBox1.Text);
            double ob = double.Parse(this.textBox2.Text);
            if (plot < 0 || ob < 0)
                MessageBox.Show("Неверный формат!");
            double weight = plot * ob;
            MessageBox.Show("Масса молока: " + weight.ToString());
        }
    }
}
