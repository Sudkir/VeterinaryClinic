using Sudarikov3ISP1113.DataBase;
using Sudarikov3ISP1113.MyClass;
using System.Windows.Controls;

namespace Sudarikov3ISP1113.View
{
    /// <summary>
    /// Логика взаимодействия для PageAddVisit.xaml
    /// </summary>
    public partial class PageAddVisit : Page
    {
        public PageAddVisit()
        {
            ClassControllerVisit classControllerVisit = new ClassControllerVisit();

            InitializeComponent();
        }
    }
}