using System.Windows;
using System.Windows.Input;

namespace GreetingWpfApp
{
    public partial class Output : Window
    {
        public Output()
        {
            InitializeComponent();
        }
        public void ShowGreeting(string greeting)
        {
            OutputTextBlock.Text = greeting;
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void OutputWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Submit_Click(sender, e);
            }
        }        
    }
}
