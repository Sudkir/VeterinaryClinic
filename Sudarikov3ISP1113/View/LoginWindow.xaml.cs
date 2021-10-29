using Sudarikov3ISP1113.DataBase;
using System.Windows;
using System.Windows.Input;

namespace Sudarikov3ISP1113
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly ClassControllerLogin CML = new ClassControllerLogin();

        //SudKirPetEntities
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (CML.ShowMain(LoginTB.Text, PasswordTB.Password))
            {
                this.Close();
            }
        }
    }
}