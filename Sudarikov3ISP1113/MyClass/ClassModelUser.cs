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



        private int _idSex;
        public int IdSexE { get => _idSex; set => _idSex = value; }

        private int _ageUser = 1;

        public int AgeUser
        {
            get => _ageUser;
            set
            {
                if (value > 0)
                {
                    _ageUser = value;
                }
            }
        }

        public List<User> ListUserLoad()
        //загрузка списка животных
        {
            List<User> listUser= new List<User>(E.User.ToList());
            return listUser;
        }


        public void NewUserAdd()
        //добавление нового петомца
        {
            User user = new User()
            {
                SName="",
                LName = "asd",
                BDate= 0.
                TelNum = TelNumE.
                Age = AgeUser,
                IdSex = IdSexE
            };
            
            E.User.Add(user);
            E.SaveChanges();
        }


    }
}