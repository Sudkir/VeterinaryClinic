namespace Sudarikov3ISP1113.DataBase
{
    using System.Collections.Generic;
    using System.Linq;

    internal class ClassModel
    {
        public static SudKirPetEntities E { get; } = new SudKirPetEntities();

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