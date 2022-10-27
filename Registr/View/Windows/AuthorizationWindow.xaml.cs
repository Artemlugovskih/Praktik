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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Registr.Core;

namespace Registr.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (UserLogin.Validate(tbLogin.Text, tbPassword.Password))
            {
                new AdminWindow().Show();
                Close();
            }
            else MessageBox.Show("Ошибка", "Неправильный логин или пароль", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
