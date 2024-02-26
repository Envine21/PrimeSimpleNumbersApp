using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using PrimeSimpleNumbersApp;
namespace SimpleNumbersApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindPrimes_Click(object sender, RoutedEventArgs e)
        {
                int start = int.Parse(startTextBox.Text);
                int end = int.Parse(endTextBox.Text);

                if (start > end)
                {
                    MessageBox.Show("Начальное значение должно быть меньше конечного значения");
                    return;
                }

                IEnumerable<int> primes = new PrimeNumberGenerator(start, end);

                resultText.Text = $"Простые числа в диапазоне от {start} до {end} : {string.Join(" , ", primes)}";

            }
 
        }
    }

    

