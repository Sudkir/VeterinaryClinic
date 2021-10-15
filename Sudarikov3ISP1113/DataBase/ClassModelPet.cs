using System.Collections.Generic;
using System.Linq;

namespace Sudarikov3ISP1113.DataBase
{
    internal class ClassModelPet
    {
        private static SudKirPetEntities e = new SudKirPetEntities();

        private int _idUserCard = 1;

        public int IdUserCard
        {
            get => _idUserCard;
            set
            {
                if (value > 0)
                {
                    _idUserCard = value;
                }
            }
        }

        private int _ageCard = 1;

        public int AgeCard
        {
            get => _ageCard;
            set
            {
                if (value > 0)
                {
                    _ageCard = value;
                }
            }
        }

        private string _namePet;

        public string NamePet
        {
            get => _namePet != null ? _namePet : "Отсутствует";
            set => _namePet = value;
        }

        private int _idSex;
        public int IdSex { get => _idSex; set => _idSex = value; }
        private int _idTypeCard;
        public int IdTypeCard { get => _idTypeCard; set => _idTypeCard = value; }

        public void NewPetAdd()
        //добавление нового петомца
        {
            MedicalCard medicalCard = new MedicalCard
            {
                IdUser = IdUserCard,
                Name = NamePet,
                Age = AgeCard,
                IdType = IdTypeCard,
                Sex = IdSex
            };
            e.MedicalCard.Add(medicalCard);
            e.SaveChanges();
        }

        public List<string> SexList()
        //Вывод списка категорий
        {
            List<string> listFiltr = new List<string>();
            List<Gender> category = e.Gender.ToList();
            foreach (var i in category)
            {
                listFiltr.Add(i.NameGender);
            }

            listFiltr.Insert(0, "Все категории");
            return listFiltr;
        }

        public List<string> TypeList()
        //Вывод списка категорий
        {
            List<string> listType = new List<string>();
            List<TypePet> category = e.TypePet.ToList();
            foreach (var i in category)
            {
                listType.Add(i.NameType);
            }

            listType.Insert(0, "Все категории");
            return listType;
        }
    }
}