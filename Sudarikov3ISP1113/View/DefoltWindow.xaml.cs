using Sudarikov3ISP1113.DataBase;
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

        PagePet pagePet = new PagePet();
        PageUser pageUser = new PageUser();
        PageVisit pageVisit = new PageVisit();
        

        public DefoltWindow()
        {
            InitializeComponent();
        }

        public DefoltWindow(Page PageName, string status)
        {
            statusDef = status;
            InitializeComponent();
            DefFraim.Navigate(PageName);
            switch (status)
            {
                case "PetStatus":

                     
                    pagePet = (PagePet)PageName;

                    break;

                case "UserStatus":
                    pageUser = (PageUser)PageName;

                    break;
                case "VisitStatus":
                    pageVisit = (PageVisit)PageName;

                    break;

                default:

                    break;
            }
                   
            ImageLoad(statusDef);
            SaveSP.Visibility = Visibility.Collapsed;
            GoBackSP.Visibility = Visibility.Collapsed;
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
            //NavigationUIVisibility="Hidden"

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

            while (DefFraim.NavigationService.CanGoBack)
            {
                DefFraim.NavigationService.RemoveBackEntry();
             } 

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
            GoBackSP.Visibility = Visibility.Visible;
            DelSP.Visibility = Visibility.Hidden;
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
        //HOME-PC\SQLEXPRESS


        private void GoBackSP_MouseLeftButtonDown_GoBack(object sender, MouseButtonEventArgs e)
        {
            if (DefFraim.NavigationService.CanGoBack)
            {
                DefFraim.NavigationService.GoBack();
            }
        }
        
        
        
        private void EditSP_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
            
            

            switch (statusDef)
            {
                case "PetStatus":

                    PageEditPet pageEdit;
                    if (pagePet.listViewPet.SelectedItem != null)
                    {
                        pageEdit = new PageEditPet(pagePet);
                        DefFraim.Navigate(pageEdit);
                    }
                    else
                    {
                        MessageBox.Show("Не выбрано животное для редактирования", 
                            "Ошибка", MessageBoxButton.OK);
                    }


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