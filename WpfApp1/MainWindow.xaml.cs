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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double first;
        double second;

        string op;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (resultTxtb.Text == "0")
            {
                resultTxtb.Text = btn.Content.ToString();
            }
            else
            {
                resultTxtb.Text += btn.Content.ToString();
            }
            first = double.Parse(resultTxtb.Text);
        }

        private void backspaceBtn_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtb.Text == "0")
            {
                resultTxtb.Text = "0";
            }
            else
            {
                if (resultTxtb.Text.Length == 1)
                {
                    resultTxtb.Text = "0";
                }
                else
                {
                    resultTxtb.Text = resultTxtb.Text.Remove(resultTxtb.Text.Length - 1, 1);
                }
            }
        }

        private void equalBtn_Click(object sender, RoutedEventArgs e)
        {
            second = double.Parse(resultTxtb.Text);
            if (op == "+")
            {
                resultTxtb.Text = (first + second).ToString();
                infoLbl.Content = "";
            }
            else if (op == "-")
            {
                resultTxtb.Text = (first - second).ToString();
                infoLbl.Content = "";
            }
            else if (op == "*")
            {
                resultTxtb.Text = (first * second).ToString();
                infoLbl.Content = "";
            }
            else if (op == "/")
            {
                if (second == 0)
                {
                    resultTxtb.Text = "Impossible";
                    infoLbl.Content = "";
                }
                else
                {
                    resultTxtb.Text = (first / second).ToString();
                    infoLbl.Content = "";
                }
            }
            else if (op == "X^Y")
            {
                resultTxtb.Text = (Math.Pow(first, second)).ToString();
                infoLbl.Content = $"{first}^{second}";
            }
        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(resultTxtb.Text);
            op = "+";
            infoLbl.Content = resultTxtb.Text + "+";
            resultTxtb.Text = "0";
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(resultTxtb.Text);
            op = "-";
            infoLbl.Content = resultTxtb.Text + "-";
            resultTxtb.Text = "0";
        }
    }
}
