using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Szemelyes_Penzugyi_Nyilvantarto
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class Login : Window
    {
        

        public Login()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string username = usernameTextBox.Text;
            string password = passwordTextBox.Password;

            if(username == "admin" && password == "admin")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}
