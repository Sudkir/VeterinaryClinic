using System.Collections.Generic;
using System.Linq;

namespace Sudarikov3ISP1113.DataBase
{
    internal class ClassModelPet : ClassModel
    {
        

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
            E.MedicalCard.Add(medicalCard);
            E.SaveChanges();
        }

        public List<MedicalCard> ListPetLoad()
        //загрузка списка животных
        {
            List<MedicalCard> listPet = new List<MedicalCard>(E.MedicalCard.ToList());
            return listPet;
        }

  
        public List<string> TypeList()
        //Вывод списка категорий
        {
            List<string> listType = new List<string>();
            List<TypePet> category = E.TypePet.ToList();
            foreach (var i in category)
            {
                listType.Add(i.NameType);
            }

            listType.Insert(0, "Все категории");
            return listType;
        }
    }
}