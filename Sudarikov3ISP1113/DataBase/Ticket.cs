//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sudarikov3ISP1113.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            this.Receipt = new HashSet<Receipt>();
        }
    
        public int IdTicket { get; set; }
        public System.DateTime TicketDate { get; set; }
        public int IdCard { get; set; }
        public int IdDoctor { get; set; }
        public int IdTypeService { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual MedicalCard MedicalCard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipt { get; set; }
        public virtual TypeService TypeService { get; set; }
    }
}
