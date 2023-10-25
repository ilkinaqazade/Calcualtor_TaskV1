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

namespace Calcualtor_V3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private double result = 0;
        private string operation = "";
        private bool isNewNumber = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetOperation(string newOperation)
        {
            if (!isNewNumber)
            {
                if (operation != "" && !isNewNumber)
                {
                    Button_Click_equalSign(null, null);
                }
               
                operation = newOperation;
                isNewNumber = true;
            }
        }
        private void AppendNumber(string number)
        {
            if (isNewNumber)
            {
                TotalLbr.Content = number;
                isNewNumber = false;
            }
            else
            {
                TotalLbr.Content += number;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            AppendNumber("7");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            AppendNumber("8");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            AppendNumber("9");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AppendNumber("4");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AppendNumber("5");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            AppendNumber("6");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppendNumber("1");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AppendNumber("2");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AppendNumber("3");
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            AppendNumber("0");
        }

        private void Button_Click_Toplama(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            TotalLbr.Content = "0";
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = "";
            isNewNumber = true;
        }

        private void Button_Click_Toplam(object sender, RoutedEventArgs e)
        {
            SetOperation("+");
        }

        private void Button_Click_minus(object sender, RoutedEventArgs e)
        {
            SetOperation("-");
        }

        private void Button_Click_equalSign(object sender, RoutedEventArgs e)
        {
            if (operation != "" && !isNewNumber)
            {
                double num1 = double.Parse(firstNumber.ToString());
                double num2 = double.Parse(TotalLbr.Content.ToString());

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Bir sayı sıfıra bölünemez!");
                        }
                        break;
                }

                TotalLbr.Content = result.ToString();
                isNewNumber = true;
            }
        }

        private void Button_Click_divisionSlash(object sender, RoutedEventArgs e)
        {
            SetOperation("/");
        }

        private void Button_Click_timesSign(object sender, RoutedEventArgs e)
        {
            SetOperation("*");
        }
    }
}
