using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            tb.Text += button.Content.ToString();
        }
        private void DEL_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";
        }
        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
        }


        private void Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception)
            {
                tb.Text = "ERROR!";
            }
        }

        private void result()
        {
            string op;
            int number = 0;
            if (tb.Text.Contains("+"))
            {
                number = tb.Text.IndexOf("+");
            }
            else if (tb.Text.Contains("-"))
            {
                number = tb.Text.IndexOf("-");
            }
            else if (tb.Text.Contains("*"))
            {
                number = tb.Text.IndexOf("*");
            }
            else if (tb.Text.Contains("/"))
            {
                number = tb.Text.IndexOf("/");
            }
            else if (tb.Text.Contains("%"))
            {
                number = tb.Text.IndexOf("%");
            }
            else
            {
                //error    
            }
            op = tb.Text.Substring(number, 1);
            double firstNumber = Convert.ToDouble(tb.Text.Substring(0, number));
            double secondNumber = Convert.ToDouble(tb.Text.Substring(number + 1, tb.Text.Length - number - 1));

            if (op == "+")
            {
                tb.Text += " = " + (firstNumber + secondNumber);
            }
            else if (op == "-")
            {
                tb.Text += " = " + (firstNumber - secondNumber);
            }
            else if (op == "*")
            {
                tb.Text += " = " + (firstNumber * secondNumber);
            }
            else if (op == "%")
            {
                tb.Text += " = " + ((firstNumber / 100) * secondNumber) + "%";
            }
            else if (op == ",")
            {
                tb.Text += "," + (firstNumber, secondNumber);
            }
            else
            {
                tb.Text += "=" + (-firstNumber / secondNumber);
            }
        }

       
    }
}
