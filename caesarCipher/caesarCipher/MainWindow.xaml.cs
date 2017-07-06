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

            //tester for translateUserInput()
            //Console.WriteLine(translateUserInput());
            //^console window never opens. maybe a wpf thing?
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

        private string translateUserInput()
        {
            string original = "ABC"; //set this to the user input
            string translated = "";

            int key = 3; //set this to the user input key

            string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //^expand this to encrypt more characters

            //mod key to get a usable one
            key = key % LETTERS.Length;

            original = original.ToUpper();
            //^remove this if upper and lowercase letters are to be used

            int transNum = 0;

            foreach (char symbol in original)
            {
                if (LETTERS.Contains(symbol))
                {
                    transNum = LETTERS.IndexOf(symbol);

                    if (modeSelect)
                    {
                        //encrypt
                        transNum += key;
                    }
                    else
                    {
                        //decrypt
                        transNum -= key;
                    }

                    if (transNum >= LETTERS.Length)
                    {
                        transNum = transNum - LETTERS.Length;
                    }
                    else if (transNum < 0)
                    {
                        transNum = transNum + LETTERS.Length;
                    }

                    translated += LETTERS[transNum];
                }
                else
                {
                    translated += symbol;
                }
            }

            return translated;

        }
    }
}
