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
using Xceed.Wpf.Toolkit;

namespace Sudarikov3ISP1113.View
{
    /// <summary>
    /// Логика взаимодействия для PageAddPet.xaml
    /// </summary>
    public partial class PageAddPet : Page
    {
        private ClassModelPet p = new ClassModelPet();

        public PageAddPet()
        {
            InitializeComponent();
            //ListLoad();
        }

        private void ListLoad()
        {
            cmbFiltrationSex.ItemsSource = p.SexList();
            cmbFiltrationSex.SelectedIndex = 0;
            cmbFiltrationType.ItemsSource = p.TypeList();
            cmbFiltrationType.SelectedIndex = 0;
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = Xceed.Wpf.Toolkit.MessageBox.Show("Hello world!", LongAge.Text, MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}