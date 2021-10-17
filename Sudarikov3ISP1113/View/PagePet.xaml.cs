using Sudarikov3ISP1113.DataBase;
using System.Windows.Controls;

namespace Sudarikov3ISP1113.View
{
    /// <summary>
    /// Логика взаимодействия для PagePet.xaml
    /// </summary>
    public partial class PagePet : Page
    {
        private ClassModelPet CMP = new ClassModelPet();

        public PagePet()
        {
            InitializeComponent();
            listViewPet.ItemsSource = CMP.ListPetLoad();
        }
    }
}