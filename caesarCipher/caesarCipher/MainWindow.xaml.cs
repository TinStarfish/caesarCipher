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

namespace caesarCipher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static bool modeSelect;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (modeSelect)
            {
                encryptWindow encrypt = new encryptWindow();
                encrypt.Show();
                this.Close();

            } else
            {

                decryptWindow decrypt = new decryptWindow();
                decrypt.Show();
                this.Close();

            }

        }

        private void EncryptRadioSelected (object sender, RoutedEventArgs e)
        {

            modeSelect = true;

        }

        private void DecryptRadioSelected(object sender, RoutedEventArgs e)
        {

            modeSelect = false;

        }


    }
}
