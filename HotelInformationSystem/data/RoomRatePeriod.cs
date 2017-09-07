namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomRatePeriod")]
    public partial class RoomRatePeriod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomRatePeriod()
        {
            RoomRates = new HashSet<RoomRate>();
        }

        public int RoomRatePeriodId { get; set; }

        [StringLength(50)]
        public string RoomRatePeriodCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RoomRatePeriodFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RoomRatePeriodTo { get; set; }

        public string RoomRatePeriodDescription { get; set; }

        public bool? RoomRatePeriodIsActive { get; set; }

        public double? RoomRatePerionPrice { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomRate> RoomRates { get; set; }
    }
}
