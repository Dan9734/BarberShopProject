//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarberShop.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personnel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personnel()
        {
            this.Record = new HashSet<Record>();
        }
    
        public int IdPersonnel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string PassportNumber { get; set; }
        public string Passport_Series { get; set; }
        public int IdGender { get; set; }
        public int IdSpecialization { get; set; }
        public string Experience { get; set; }

        public string INFO { get => $"{FirstName} {LastName} {Phone} {PassportNumber} {Passport_Series} {Experience}"; }

        public string DOPE { get => $"{FirstName} {LastName}"; }


        public virtual Gender Gender { get; set; }
        public virtual Specialization Specialization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Record> Record { get; set; }
    }
}
