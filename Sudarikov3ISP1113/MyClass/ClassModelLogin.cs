using Sudarikov3ISP1113.View;
using System.Linq;
using System.Windows;

namespace Sudarikov3ISP1113.DataBase
{
    internal class ClassModelLogin : ClassModel
    {
       

        private MainWindow mainWindow = new MainWindow();

        public void ShowMain()
        {
            mainWindow.Show();
        }

        public bool ShowMain(string LoginStr, string PassStr)
        {
            try
            {
                Employees userModel = E.Employees.FirstOrDefault
                (i => i.SName == LoginStr && i.LName == PassStr);
                var idR = userModel.IdRole;

                if (userModel == null)
                {
                    MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK);
                    return false;
                }
                else
                {
                    switch (idR)
                    {
                        case 1:
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.Show();
                            return true;

                        default:
                            MessageBox.Show("Пароль не совпадает", "Ошибка", MessageBoxButton.OK);
                            return false;
                    }
                }
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButton.OK);
                return false;
            }
        }
    }
}