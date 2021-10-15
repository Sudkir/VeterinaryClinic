using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sudarikov3ISP1113.View
{
    /// <summary>
    /// Логика взаимодействия для DefoltWindow.xaml
    /// </summary>
    public partial class DefoltWindow : Window
    {
        

        public DefoltWindow()
        {
            InitializeComponent();
        }

        public DefoltWindow(Page x, string status)
        {
            InitializeComponent();
            DefFraim.Navigate(x);
            switch (status)
            {
                case "PetStatus":
                    BitmapImage bi1 = new BitmapImage();
                    bi1.BeginInit();
                    bi1.UriSource = new Uri("/Sudarikov3ISP1113;component/Icon/piggy.png", UriKind.Relative);
                    bi1.EndInit();
                    NewObjectImage.Stretch = Stretch.Fill;
                    NewObjectImage.Source = bi1;
                    
                    break;

                case "UserStatus":
                    
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri("/Sudarikov3ISP1113;component/Icon/avatar.png", UriKind.Relative);
                    bi3.EndInit();
                    NewObjectImage.Stretch = Stretch.Fill;
                    NewObjectImage.Source = bi3;
                    break;

                case "VisitStatus":

                    BitmapImage bi2 = new BitmapImage();
                    bi2.BeginInit();
                    bi2.UriSource = new Uri("/Sudarikov3ISP1113;component/Icon/book.png", UriKind.Relative);
                    bi2.EndInit();
                    NewObjectImage.Stretch = Stretch.Fill;
                    NewObjectImage.Source = bi2;
                    break;
                default:

                    break;
            }

        }

        private void goMain() {

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

        }
    }
}
