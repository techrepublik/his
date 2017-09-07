namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            CashInOuts = new HashSet<CashInOut>();
        }

        public int UserId { get; set; }

        public int? EmployeeId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserPassword { get; set; }

        public int? UserLevel { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UserExpiryDate { get; set; }

        public string UserNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashInOut> CashInOuts { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
