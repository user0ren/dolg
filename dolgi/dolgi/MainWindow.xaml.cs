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

namespace fotran
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void ShowPassword(object sender, RoutedEventArgs e)
        {
            if (TextBoxPassword.Visibility == Visibility.Hidden)
            {
                TextBoxPassword.Text = PasswordBoxPassword.Password;
                TextBoxPassword.Visibility = Visibility.Visible;
                PasswordBoxPassword.Visibility = Visibility.Hidden;
            }
            else
            {
                PasswordBoxPassword.Password = TextBoxPassword.Text;
                TextBoxPassword.Visibility = Visibility.Hidden;
                PasswordBoxPassword.Visibility = Visibility.Visible;
            }
        }

        private void EnterLoginPassword(object sender, RoutedEventArgs e)
        {
            string[] loginArr = { "Admin", "Tom", "Sam", "Bob" };
            string[] passwordArr = { "Admin", "TomCool", "TomFool", "CrazyFrog" };
            int login = Array.IndexOf(loginArr, TextBoxLogin.Text);
            int password = Array.IndexOf(passwordArr, PasswordBoxPassword.Password);
            if (login != -1 && login == password)
            {
                Close();
                //newForm.Show();
            }
            else
                MessageBox.Show("Неверный пароли или логин", "Ошибка входа");

        }

        private void TextBoxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            PasswordBoxPassword.Password = TextBoxPassword.Text;
        }
    }
}
