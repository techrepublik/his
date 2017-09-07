namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            RoomCharges = new HashSet<RoomCharge>();
        }

        public int ServiceId { get; set; }

        [StringLength(50)]
        public string ServiceName { get; set; }

        public double? ServiceAmount { get; set; }

        public bool? ServiceIsVat { get; set; }

        public bool? ServiceIsService { get; set; }

        public bool? ServiceIsActive { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomCharge> RoomCharges { get; set; }
    }
}
