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
        public int userKey;
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

                setUserInput();

                userKey = getUserKey();
                this.outputBox.Text = "(key: " + userKey + ") "+ translateUserInput();
               

            }
            else  //This leads to the decrypter
            {

                setUserInput();
                userKey = getUserKey();
                this.outputBox.Text = "(key: " + userKey + ") " + translateUserInput();
                

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

        public void setUserInput()
        {

            userEnteredValue = userText.Text;

        }

     

        private void deleteText(object sender, MouseButtonEventArgs e)
        {

            userText.Clear();

        }
        
        private int getUserKey ()
        {

            string i = this.encryptionKey.Text;
            int j;
            if (int.TryParse(i, out j))
            {

                return j;

            }

            return j;

        }

        private string translateUserInput()
        {
            string original = userEnteredValue; //set this to the user input
            string translated = "";

            int key = userKey; //set this to the user input key

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

        private void deleteText(object sender, RoutedEventArgs e)
        {

            encryptionKey.Clear();

        }

        private void deleteUserText(object sender, RoutedEventArgs e)
        {

            userText.Clear();

        }

        private void copyOutputToClipboard(object sender, RoutedEventArgs e)
        {

            Clipboard.SetText(translateUserInput());

        }
    }
}
