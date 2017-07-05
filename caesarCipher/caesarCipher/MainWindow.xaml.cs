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

        public string userEnteredValue;
        public static bool modeSelect;
        public static bool firstSelected;

        public MainWindow()
        {
            InitializeComponent();

         //Initialize Variables Here
            modeSelect = true;
            firstSelected = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (modeSelect) //This leads to the Encrypter
            {
                encryptWindow encrypt = new encryptWindow();

                encrypt.setUserInput(userEnteredValue);

                encrypt.Show();
                this.Close();

            }
            else  //This leads to the decrypter
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


        private void deleteText(object sender, MouseEventArgs e)
        {
            if (firstSelected)
                 userText.Clear();

            firstSelected = false;

        }

        public string getUserInput()
        {

            return userEnteredValue;

        }

        public void setUserInput(string c)
        {

            userEnteredValue = c;

        }

        private void deleteText(object sender, MouseButtonEventArgs e)
        {

            userText.Clear();

        }

        private string encryptUserInput()
        {

            string encryptedMessage = "";


            return encryptedMessage;

        }
    }
}
