﻿using Sudarikov3ISP1113.DataBase;
using System.Windows;
using System.Windows.Input;

namespace Sudarikov3ISP1113
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly ClassModelLogin CML = new ClassModelLogin();

        //SudKirPetEntities
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (CML.ShowMain(LoginTB.Text, PasswordTB.Text))
            {
                this.Close();
            }
        }

        /*
            System.Windows.MessageBox.Show(
        "Выберите один из вариантов",
        "Сообщение",
        (MessageBoxButton)MessageBoxButtons.YesNo);
            */
    }
}