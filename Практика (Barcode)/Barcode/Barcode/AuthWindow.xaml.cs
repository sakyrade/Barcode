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

namespace Barcode
{
    public partial class AuthWindow : Window
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            Window window = null;
            Profile prof = Authorization.Auth(txtLoginBox.Text, passBox.Password);
            if (prof is Admin)
                window = new AdminWindow();
            else if (prof is User)
                window = new UserWindow();
            else
            {
                MessageBox.Show("Неверные логин или пароль.", "Ошибка");
                return;
            }
            window.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
