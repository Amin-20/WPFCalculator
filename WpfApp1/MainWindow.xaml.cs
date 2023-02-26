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
            Button btn = (Button)sender;
            if (resultTxtb.Text == "0")
            {
                resultTxtb.Text = btn.Content.ToString();
            }
            else
            {
                resultTxtb.Text += btn.Content.ToString();
            }
            second = double.Parse(resultTxtb.Text);
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
            double result = 0;
            try
            {
                if (op == "+")
                {
                    result = first + second;
                    resultTxtb.Text = result.ToString();
                }
                else if (op == "-")
                {
                    result = first - second;
                    resultTxtb.Text = result.ToString();
                }
                else if (op == "*")
                {
                    result = first * second;
                    resultTxtb.Text = result.ToString();
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
                        result = first / second;
                        resultTxtb.Text = result.ToString();
                    }
                }
                else if (op == "X^Y")
                {
                    result = Math.Pow(first, second);
                    infoLbl.Content = $"{first}^{second}";
                    resultTxtb.Text = result.ToString();
                }
            }
            catch (Exception)
            {
                

            }

            infoLbl.Content = "";
        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(resultTxtb.Text);
            op = "+";
            infoLbl.Content = resultTxtb.Text + "+";
            resultTxtb.Text = "0";
        }

        private void divBtn_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(resultTxtb.Text);
            op = "/";
            infoLbl.Content = resultTxtb.Text + "÷";
            resultTxtb.Text = "0";
        }

        private void multBtn_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(resultTxtb.Text);
            op = "*";
            infoLbl.Content = resultTxtb.Text + "×";
            resultTxtb.Text = "0";
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(resultTxtb.Text);
            op = "-";
            infoLbl.Content = resultTxtb.Text + "-";
            resultTxtb.Text = "0";
        }

        private void cleanBtn_Click(object sender, RoutedEventArgs e)
        {
            resultTxtb.Text = "0";
            infoLbl.Content = "";
        }

        private void pointBtn_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtb.Text == "0")
            {
                resultTxtb.Text = "0";
            }
            if (!resultTxtb.Text.Contains(","))
            {
                resultTxtb.Text += ",";
            }
        }

        private void x2_Click(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(resultTxtb.Text);
            infoLbl.Content = $"{num}^2";
            num = Math.Pow(num, 2);
            resultTxtb.Text = num.ToString();
        }



        private void randSquareBtn_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(resultTxtb.Text);
            op = "X^Y";
            infoLbl.Content = resultTxtb.Text + "^";
            resultTxtb.Text = "0";
        }

        private void pozitiveOrPozitiveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (resultTxtb.Text == "0")
            {
                resultTxtb.Text = "0";
            }
            else
            {
                if (!resultTxtb.Text.Contains("-"))
                {
                    resultTxtb.Text = $"-{resultTxtb.Text}";
                }
                else
                {
                    resultTxtb.Text = resultTxtb.Text.Replace("-", "");
                }
            }
        }

        private void powBtn_Click(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(resultTxtb.Text);
            infoLbl.Content = $"√{num}";
            num = Math.Sqrt(num);
            resultTxtb.Text = num.ToString();
        }



        //private void minusBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    first = double.Parse(resultTxtb.Text);
        //    op = "-";
        //    infoLbl.Content = resultTxtb.Text + "-";
        //    resultTxtb.Text = "0";
        //}
    }
}
