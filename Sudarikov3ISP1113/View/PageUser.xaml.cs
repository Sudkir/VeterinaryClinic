using Sudarikov3ISP1113.DataBase;
using System.Windows.Controls;

namespace Sudarikov3ISP1113.View
{
    /// <summary>
    /// Логика взаимодействия для PageUser.xaml
    /// </summary>
    public partial class PageUser : Page
    {

        private ClassModelUser CMU = new ClassModelUser();

        public PageUser()
        {
            InitializeComponent();
            listViewPet.ItemsSource = CMU.ListUserLoad();
        }
    }
}