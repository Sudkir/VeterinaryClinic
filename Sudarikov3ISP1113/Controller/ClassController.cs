namespace Sudarikov3ISP1113.DataBase
{
    using System.Collections.Generic;
    using System.Linq;

    internal class ClassController
    {
        public static SudKirPetEntities E { get; } = new SudKirPetEntities();

        public List<Employees> ListEmployeesLoad => E.Employees.ToList();

        public List<User> ListUserLoad => E.User.ToList();

        public List<MedicalCard> ListMedicalCardLoad => E.MedicalCard.ToList();

        public List<string> CategoryPet()
        //Вывод списка категорий
        {
            List<string> list = new List<string>();
            List<TypePet> category = E.TypePet.ToList();
            foreach (var i in category)
            {
                list.Add(i.NameType);
            }

            list.Insert(0, "Все категории");
            return list;
        }

        public List<string> SexList()
        //Вывод списка категорий
        {
            List<string> listFiltr = new List<string>();
            List<Gender> category = E.Gender.ToList();
            foreach (var i in category)
            {
                listFiltr.Add(i.NameGender);
            }

            listFiltr.Insert(0, "Все категории");
            return listFiltr;
        }
    }
}