
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = ayudanombreTextBlock;
            apellidoTextBox.Tag = ayudaapellidoTextBlock;
        }


        private void ayudaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb =(TextBox)sender;
            if (e.Key == Key.F1 && (tb.Tag as TextBlock).Visibility==Visibility.Hidden)
            {
               (tb.Tag as TextBlock).Visibility = Visibility.Visible;
            }
            else if(e.Key == Key.F1)
            {
                (tb.Tag as TextBlock).Visibility = Visibility.Hidden;
            }
        }

        private void edadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2 && !Regex.IsMatch(edadTextBox.Text,"^[0-9]+$"))
            {
                ayudaedadTextBlock.Text = "Edad incorrecta";
            }
            else if(e.Key == Key.F2)
            {
                ayudaedadTextBlock.Text = "";
            }
        }
    }
}
