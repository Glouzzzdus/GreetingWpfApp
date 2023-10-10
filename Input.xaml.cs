using System.Windows;
using System.Windows.Input;
using GreetingLib;

namespace GreetingWpfApp
{
    public partial class Input : Window
    {
        public Input()
        {
            InitializeComponent();
        }

        private void ShowGreetingButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            if (username.Length > 0)
            {
                string greeting = GreetingGenerator.GenerateGreeting(username); 

                            Output outputWindow = new Output();
                            outputWindow.ShowGreeting(greeting);
                            Close();
                            outputWindow.Show();
            }
            else
            {
                WarningTextBlock.Text = "Please enter your name!";
            }
            
        }
        private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ShowGreetingButton_Click(sender, e);
            }
        }

    }
}

