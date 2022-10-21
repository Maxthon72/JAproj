using JAdll;

namespace JA_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Class1.add(12, 3).ToString();
        }
    }
}