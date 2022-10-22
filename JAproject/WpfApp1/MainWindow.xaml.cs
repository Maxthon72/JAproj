using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            [DllImport(@"C:\Users\Macie\JA\JAproject\JAproject\WpfApp1\x64\Debug\ASMdll.dll")]
            static extern int MyProc1(int a, int b);
            int x = 12;
            int y = 5;
            int retVal = MyProc1(x, y);
            textBox.Text = retVal.ToString();
        }
    }
}
