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
        private PageAddUser pageAddUser = new PageAddUser();
        private PageAddPet pageAddPet = new PageAddPet();
        private MainWindow mainWindow = new MainWindow();
        private PageAddVisit pageAddVisit = new PageAddVisit();

        public DefoltWindow()
        {
            InitializeComponent();
        }

        public DefoltWindow(Page PageName, string status)
        {
            statusDef = status;
            InitializeComponent();
            DefFraim.Navigate(PageName);
            ImageLoad(statusDef);
            SaveSP.Visibility = Visibility.Collapsed;
        }

        private void NewObjectImageLoad(string UriS)
        //загрузка изображений
        {
            BitmapImage BI = new BitmapImage();
            BI.BeginInit();
            BI.UriSource = new Uri(UriS, UriKind.Relative);
            BI.EndInit();
            NewObjectImage.Stretch = Stretch.Fill;
            NewObjectImage.Source = BI;
            BI = null;
        }

        private void ImageLoad(string status)
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
        //назад
        {
            mainWindow.Show();
            this.Close();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            goMain();
        }

        private void NewObject_MouseLeftButtonDown_NewObject(object sender, MouseButtonEventArgs e)
        //добавить новое
        {
            VisabilBtn();

            switch (statusDef)
            {
                case "PetStatus":

                    DefFraim.Navigate(pageAddPet);

                    break;

                case "UserStatus":

                    DefFraim.Navigate(pageAddUser);

                    break;

                case "VisitStatus":
                    DefFraim.Navigate(pageAddVisit);

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

                    pageAddPet.SaveAddPet();

                    break;

                case "UserStatus":

                    pageAddUser.SaveAddUser();

                    break;

                case "VisitStatus":

                    break;

                default:

                    break;
            }
        }
    }
}