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

namespace WpfVerticalMDISimulation
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

        // Event to add new child windows
        private void NewWindow_Click(object sender, RoutedEventArgs e)
        {
            // Create a new child window
            var child = new ChildWindow
            {
                Title = $"Child Window {ChildContainer.Children.Count + 1}",
                Width = 700,
                Height = 150,
                Margin = new Thickness(10)
            };

            // Add the child window to the vertical container
            ChildContainer.Children.Add(child);
        }

        // Exit the application
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}