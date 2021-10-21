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
    /// Логика взаимодействия для PageAddUser.xaml
    /// </summary>
    public partial class PageAddUser : Page
    {


        private ClassModelUser u = new ClassModelUser();

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

                ClassModelUser classModelUser = new ClassModelUser
                {
                    SNameE = NameTB.Text,
                    LNameE = NameTB.Text,
                    IdSexE = cmbFiltrationSex.SelectedIndex,
                    TelNumE = Convert.ToInt32(TelNumTB.Text),
                    LoginE = LogTB.Text,
                    PasswordE = PassTB.Text
                };

                classModelUser.NewUserAdd();
                
            }
            else
            {
                //do stuff if No
                //clear поля
            }
        }

    }
}
