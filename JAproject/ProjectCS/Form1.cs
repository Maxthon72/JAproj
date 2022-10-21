using System.Runtime.InteropServices;

namespace ProjectCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            [DllImport(@"C:\Users\Macie\JA\JAproject\JAproject\ProjectCS\x64\Debug\ProjectDll.dll ")]
            static extern int MyProc1(int a, int b);

            int x = 5, y = 3;
            int retVal = MyProc1(x, y);

            textBox1.Text = retVal.ToString();
        }
    }
}