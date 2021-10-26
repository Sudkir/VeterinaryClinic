using Sudarikov3ISP1113.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudarikov3ISP1113.MyClass
{
    internal class ClassControllerVisit : ClassController
    {
        public void AddNewVisit(DateTime date, int IDCard, int IDDoctor, int IDTypeService)
        {
            Ticket ticket = new Ticket
            {
                TicketDate = date.Date,
                IdCard = IDCard,
                IdDoctor = IDDoctor,
                IdTypeService = IDTypeService
            };
            E.Ticket.Add(ticket);
            E.SaveChanges();
        }
    }
}