using System.Windows;

namespace App1
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


        private void saludar_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "Hola Caracola!";
        }

        private void limpiar_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }
    }
}
