namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomJobOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomJobOrder()
        {
            RoomCleans = new HashSet<RoomClean>();
        }

        [Key]
        public int JobOrderId { get; set; }

        public int? JobOrderNo { get; set; }

        public DateTime? JobOrderDate { get; set; }

        public string JobOrderDescription { get; set; }

        public bool? JobOrderIsActive { get; set; }

        public int? EmployeeId { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomClean> RoomCleans { get; set; }
    }
}
