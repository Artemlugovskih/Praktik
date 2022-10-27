using System;
using System.Collections.Generic;
using System.Linq;
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
using Registr.Model;
using Registr.View.Pages;

namespace Registr.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void btnLoadUsers_Ckick(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new UsersPage());
            Width = 800;
        }

        private void btnLoadSome_Ckick(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SomePage());
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = UserPassword.ParseFile("users2.txt").ToList();
            var reapeatedUser = users.FirstOrDefault(u => u.FirstName == tbFirstName.Text && u.MiddleName == tbMiddleName.Text && u.LastName == tbLastName.Text);
           // if(reapeatedUser is not null)
           // {
             //   MessageBox.Show("Пользователь уже существует");
           // }
          //  else
           // {
                //UserPassword.AddUser("users2.txt", new User(tbFirstName.Text, tbMiddleName.Text, tbLastName.Text, Convert.ToString32(tbBordDate.Text), Convert.ToDecimal(tbSalary.Text)));
               // ClearTextFields();
               // mainFrame.Navigate(new UsersPage());
           // }
        }
    }
}
