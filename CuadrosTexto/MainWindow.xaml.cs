
using System.Windows;
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
        }


        private void nombreTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1 && ayudanombreTextBlock.Text.Length == 0)
            {
                ayudanombreTextBlock.Text = "Nombre del cliente";
            }
            else if(e.Key == Key.F1)
            {
                ayudanombreTextBlock.Text = "";
            }
        }

        private void apellidoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1 && ayudaapellidoTextBlock.Text.Length==0)
            {
                ayudaapellidoTextBlock.Text = "Apellido del cliente";
            }
            else if(e.Key == Key.F1)
            {
                ayudaapellidoTextBlock.Text = "";
            }
        }

        private void edadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            int numero;
            bool correcto = int.TryParse(ayudaedadTextBlock.Text, out numero);

            if (e.Key == Key.F2 && !correcto)
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
