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
using System.Windows.Shapes;

namespace caesarCipher
{
    /// <summary>
    /// Interaction logic for encryptWindow.xaml
    /// </summary>
    public partial class encryptWindow : Window
    {

        public static string userInput;


        public encryptWindow()
        {
            InitializeComponent();
            unencryptedData.Text = userInput;
        
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {

            MainWindow home = new MainWindow();
            home.Show();
            this.Close();

        }

        public void setUserInput(string s)
        {

            userInput = s;

        }
    }
}
