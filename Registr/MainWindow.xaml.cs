
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
using Registr.View.Windows;

namespace Registr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
