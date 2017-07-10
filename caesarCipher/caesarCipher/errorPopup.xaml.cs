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
    /// Interaction logic for errorPopup.xaml
    /// </summary>
    public partial class errorPopup : Window
    {
        public errorPopup()
        {
            InitializeComponent();
        }

        private void returnHome(object sender, RoutedEventArgs e)
        {

            MainWindow home = new MainWindow();
            home.Show();
            this.Close();


        }
    }
}
