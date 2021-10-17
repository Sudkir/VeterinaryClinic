using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Sudarikov3ISP1113.View
{
    /// <summary>
    /// Логика взаимодействия для DefoltWindow.xaml
    /// </summary>
    public partial class DefoltWindow : Window
    {
        private string statusDef;

        public DefoltWindow()
        {
            InitializeComponent();
        }

        public DefoltWindow(Page x, string status)
        {
            statusDef = status;
            InitializeComponent();
            DefFraim.Navigate(x);
            NewMethod(statusDef);
            SaveSP.Visibility = Visibility.Collapsed;
        }

        private void NewObjectImageLoad(string UriS)
        {
            BitmapImage bi1 = new BitmapImage();
            bi1.BeginInit();
            bi1.UriSource = new Uri(UriS, UriKind.Relative);
            bi1.EndInit();
            NewObjectImage.Stretch = Stretch.Fill;
            NewObjectImage.Source = bi1;
        }

        private void NewMethod(string status)
        {
            switch (status)
            {
                case "PetStatus":

                    NewObjectImageLoad("/Sudarikov3ISP1113;component/Icon/piggy.png");

                    break;

                case "UserStatus":
                    NewObjectImageLoad("/Sudarikov3ISP1113;component/Icon/avatar.png");

                    break;

                case "VisitStatus":
                    NewObjectImageLoad("/Sudarikov3ISP1113;component/Icon/book.png");

                    break;

                default:

                    break;
            }
        }

        private void goMain()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            goMain();
        }

        private void TextBlock_MouseLeftButtonDown_NewObject(object sender, MouseButtonEventArgs e)
        {
            VisabilBtn();

            switch (statusDef)
            {
                case "PetStatus":
                    PageAddPet pageAddPet = new PageAddPet();
                    DefFraim.Navigate(pageAddPet);

                    break;

                case "UserStatus":

                    break;

                case "VisitStatus":

                    break;

                default:

                    break;
            }
        }

        private void VisabilBtn()
        {
            EditSP.Visibility = Visibility.Hidden;
            ResSP.Visibility = Visibility.Hidden;
            SaveSP.Visibility = Visibility.Visible;
            AddObjSP.Visibility = Visibility.Hidden;
        }

        private void Save_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            switch (statusDef)
            {
                case "PetStatus":
                    PageAddPet pageAddPet = new PageAddPet();
                    pageAddPet.SaveAddPet();

                    break;

                case "UserStatus":

                    break;

                case "VisitStatus":

                    break;

                default:

                    break;
            }
        }
    }
}