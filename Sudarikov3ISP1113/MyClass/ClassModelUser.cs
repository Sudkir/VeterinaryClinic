using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudarikov3ISP1113.DataBase
{
    internal class ClassModelUser : ClassModel
    {
        private int _telNum = 1;

        public int TelNumE
        {
            get => _telNum;
            set
            {
                if (value > 0)
                {
                    _telNum = value;
                }
            }
        }

        private int AgeE(DateTime dateTime)
        {
            if (dateTime != null)
            {
                DateTime now = DateTime.Today;
                int age = now.Year - dateTime.Year;

                if (dateTime > now.AddYears(-age))
                {
                    age--;
                }
                return age;
            }
            return 0;
        }

        public int IdSexE { get; set; }
        public string LoginE { get; set; }

        public string PasswordE { get; set; }

        public string SNameE { get; set; }

        public string LNameE { get; set; }
        public DateTime Date { get; set; } = new DateTime();

        public List<User> ListUserLoad()
        //загрузка списка животных
        {
            List<User> listUser = new List<User>(E.User.ToList());
            return listUser;
        }

        public void NewUserAdd()
        //добавление нового петомца
        {
            User user = new User()
            {
                SName = SNameE,
                LName = LNameE,
                BDate = Date,
                TelNum = TelNumE,
                Age = AgeE(Date),
                IdSex = IdSexE,
                Login = LoginE,
                Password = PasswordE
            };

            E.User.Add(user);
            E.SaveChanges();
        }
    }
}