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

namespace Tema2_TamanyoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RadioButton1.IsChecked = true;
            RadioButton1.Tag = 1;
            RadioButton2.Tag = 2;
            RadioButton3.Tag = 3;
        }

        private void RadioButtonChecked(object sender, RoutedEventArgs e)
        {
            RadioButton boton = sender as RadioButton;
            
            switch (boton.Tag)
            {
                case 1:
                    TexBlock1.FontSize = 36;
                    break;
                case 2:
                    TexBlock1.FontSize = 48;
                    break;
                case 3:
                    TexBlock1.FontSize = 72;
                    break;
            }
        }
    }
}
