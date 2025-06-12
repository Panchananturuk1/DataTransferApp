using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace DataTransferApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string herculesData = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        // Allow only numeric input
        private void TextBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.Text, "^[0-9]+$");
        }

        // Simulate sending data to Hercules Terminal
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text.Length == 16)
            {
                herculesData = TextBox1.Text;
                MessageBox.Show("Data sent to Hercules Terminal.");
            }
            else
            {
                MessageBox.Show("Please enter exactly 16 numeric digits.");
            }
        }

        // Simulate receiving data from Hercules Terminal
        private void ReceiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(herculesData))
            {
                TextBox2.Text = herculesData;
            }
            else
            {
                MessageBox.Show("No data received from Hercules Terminal.");
            }
        }
    }
}
