namespace Sudarikov3ISP1113.DataBase
{
    class ClassModelPet
    {
        public static SudKirPetEntities Entities = new SudKirPetEntities();

        int _idUserCard = 1;

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

        int _ageCard = 1;

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

        string _namePet;

        public string NamePet { get => _namePet != null ? _namePet : "Отсутствует";
            set => _namePet = value; }

        int _idSex;
        public int IdSex { get => _idSex; set => _idSex = value; }
        int _idTypeCard;
        public int IdTypeCard { get => _idTypeCard; set => _idTypeCard = value; }

        

        public void NewPetAdd()
        {
            MedicalCard medicalCard = new MedicalCard();
            medicalCard.IdUser = IdUserCard;
            medicalCard.Name = NamePet;
            medicalCard.Age = AgeCard;
            medicalCard.IdType = IdTypeCard;
            medicalCard.Sex = IdSex;
            Entities.MedicalCard.Add(medicalCard);
            Entities.SaveChanges();
        }
    }
}
