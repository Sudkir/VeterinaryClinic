using Sudarikov3ISP1113.DataBase;
using System;
using System.Windows;
using System.Windows.Controls;

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

        public void SaveAddPet()
        {
            MessageBoxResult result = Xceed.Wpf.Toolkit.MessageBox.Show("Сохранить?", "Подтвержнение",
                MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (MessageBoxResult.OK == result)
            {
                ClassModelPet ModelPet = new ClassModelPet
                {
                    IdUserCard = Convert.ToInt32(idUserTB.Text),
                    NamePet = NameTB.Text,
                    AgeCard = Convert.ToInt32(LongAge.Text),
                    IdTypeCard = cmbFiltrationType.SelectedIndex,
                    IdSex = cmbFiltrationSex.SelectedIndex
                };
                ModelPet.NewPetAdd();
            }
            else
            {
                //do stuff if No
                //clear поля
            }
        }

      
    }
}