using Sudarikov3ISP1113.MyClass;
using Sudarikov3ISP1113.View;
using System.Linq;
using System.Windows;

namespace Sudarikov3ISP1113.DataBase
{
    internal class ClassControllerLogin : ClassController
    {
        private MainWindow mainWindow = new MainWindow();

        public void ShowMain()
        {
            mainWindow.Show();
        }
        /*
        public bool ShowMain(string LoginStr, string PassStr)
        {
            try
            {
                Employees userModel = E.Employees.FirstOrDefault
                (i => i.Login == LoginStr && i.Password == PassStr);

                if (userModel == null)
                {
                    MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK);
                    return false;
                }
                else
                {
                    ClassRole.Instance.UserRoleInstance = userModel.IdRole;
                    ClassRole.Instance.UserIdInstance = userModel.IdEmployees;

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    return true;
                }
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButton.OK);
                return false;
            }
        }
    
         */
    }
}

       