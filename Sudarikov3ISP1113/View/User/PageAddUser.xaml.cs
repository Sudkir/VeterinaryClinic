using Sudarikov3ISP1113.DataBase;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Sudarikov3ISP1113.View
{
    /// <summary>
    /// Логика взаимодействия для PageAddUser.xaml
    /// </summary>
    public partial class PageAddUser : Page
    {
        private ClassControllerUser u = new ClassControllerUser();

        public PageAddUser()
        {
            InitializeComponent();
            ListLoad();
        }

        private void ListLoad()
        {
            cmbFiltrationSex.ItemsSource = u.SexList();
            cmbFiltrationSex.SelectedIndex = 0;
        }

        public void SaveAddUser()
        {
            MessageBoxResult result = Xceed.Wpf.Toolkit.MessageBox.Show("Сохранить?", "Подтвержнение",
                MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (MessageBoxResult.OK == result)
            {
                u.SNameE = SNameTB.Text;
                u.LNameE = LNameTB.Text;
                u.IdSexE = cmbFiltrationSex.SelectedIndex;
                u.TelNumE = Convert.ToInt32(TelNumTB.Text);
                u.Date = (DateTime)DatePic.SelectedDate;
                u.NewUserAdd();
                ClearAddUser();
            }
            else
            {
                ClearAddUser();
            }
        }

        private void ClearAddUser()
        {
            SNameTB.Text = null;
            LNameTB.Text = null;
            cmbFiltrationSex.SelectedIndex = 0;
            TelNumTB.Text = null;
            DatePic.SelectedDate = null;
        }
    }
}