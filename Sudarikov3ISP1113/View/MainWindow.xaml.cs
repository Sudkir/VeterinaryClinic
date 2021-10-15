using System.Windows;
using System.Windows.Input;

namespace Sudarikov3ISP1113.View
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

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PagePet pagePet = new PagePet();
            DefoltWindow defoltWindow = new DefoltWindow(pagePet, "PetStatus");

            defoltWindow.Show();
            this.Close();
        }

        private void TextBlock_MouseLeftButtonUp_User(object sender, MouseButtonEventArgs e)
        {
            PageUser pageUser = new PageUser();
            DefoltWindow defoltWindow = new DefoltWindow(pageUser, "UserStatus");

            defoltWindow.Show();
            this.Close();
        }

        private void StackPanel_MouseLeftButtonUp_Visit(object sender, MouseButtonEventArgs e)
        {
            PageVisit pageVisit = new PageVisit();
            DefoltWindow defoltWindow = new DefoltWindow(pageVisit, "VisitStatus");

            defoltWindow.Show();
            this.Close();
        }
    }
}