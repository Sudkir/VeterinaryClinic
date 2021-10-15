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
    /// Логика взаимодействия для PageAddPet.xaml
    /// </summary>
    public partial class PageAddPet : Page
    {
        ClassModelPet p = new ClassModelPet();
        public PageAddPet()
        {
            InitializeComponent();

            cmbFiltrationSex.ItemsSource = p.SexList();
            cmbFiltrationSex.SelectedIndex = 0;
            cmbFiltrationType.ItemsSource = p.TypeList();
            cmbFiltrationType.SelectedIndex = 0;
        }
    }
}
