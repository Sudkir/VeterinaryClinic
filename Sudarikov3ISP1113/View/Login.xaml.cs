using Sudarikov3ISP1113.View;
using System.Windows;
using System.Windows.Input;

namespace Sudarikov3ISP1113
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        //SudKirPetEntities
        public Login()
        {
            InitializeComponent();
        }

        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            /*
            System.Windows.MessageBox.Show(
        "Выберите один из вариантов",
        "Сообщение",
        (MessageBoxButton)MessageBoxButtons.YesNo);
            */

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
