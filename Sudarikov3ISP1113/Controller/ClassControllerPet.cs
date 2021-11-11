using Sudarikov3ISP1113.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudarikov3ISP1113.DataBase
{
    internal class ClassControllerPet : ClassController
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

         
        public void LoadEditPet(PagePet pagePet, PageEditPet pageEditPet)
        {
            int id=0;
            if (pagePet.listViewPet.SelectedItem is MedicalCard medicalCard)
            {
                id = medicalCard.IdCard;
            }

            MedicalCard medicalcard = E.MedicalCard.FirstOrDefault(i => i.IdCard == id);
            pageEditPet.NameTB.Text = medicalcard.Name;
            pageEditPet.LongAge.Value = medicalcard.Age;
            pageEditPet.cmbFiltrationSex.SelectedIndex = medicalcard.Sex;
            pageEditPet.cmbFiltrationType.SelectedIndex = medicalcard.IdType;
            pageEditPet.idUserTB.Text = Convert.ToString( medicalcard.IdUser);
        }


        public void SaveEditPet(int id, PageEditPet pageEditPet)
        {
            MedicalCard medicalcard = E.MedicalCard.FirstOrDefault(i => i.IdCard == id);
            medicalcard.Name = pageEditPet.NameTB.Text;
            medicalcard.Age = (int)pageEditPet.LongAge.Value;
            medicalcard.IdType = pageEditPet.cmbFiltrationType.SelectedIndex;
            medicalcard.Sex = pageEditPet.cmbFiltrationSex.SelectedIndex;
            medicalcard.IdUser = Convert.ToInt32(pageEditPet.idUserTB.Text);
        }
    }
}