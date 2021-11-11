using Sudarikov3ISP1113.DataBase;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sudarikov3ISP1113.View
{
    /// <summary>
    /// Логика взаимодействия для PageEditPet.xaml
    /// </summary>
    public partial class PageEditPet : Page
    {
        ClassControllerPet CCP = new ClassControllerPet();

        public PageEditPet(PagePet pet)
        {
            InitializeComponent();
            ListLoad();
            CCP.LoadEditPet(pet,this);
        }

        private void ListLoad()
        {
            cmbFiltrationSex.ItemsSource = CCP.SexList();
            cmbFiltrationSex.SelectedIndex = 0;
            cmbFiltrationType.ItemsSource = CCP.CategoryPet();
            cmbFiltrationType.SelectedIndex = 0;
        }



    }
}
