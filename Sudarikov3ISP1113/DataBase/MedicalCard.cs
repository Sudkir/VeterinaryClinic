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
    
    public partial class MedicalCard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalCard()
        {
            this.DiseaseHistory = new HashSet<DiseaseHistory>();
            this.Ticket = new HashSet<Ticket>();
        }
    
        public int IdCard { get; set; }
        public int IdUser { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int IdType { get; set; }
        public int Sex { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiseaseHistory> DiseaseHistory { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual TypePet TypePet { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
