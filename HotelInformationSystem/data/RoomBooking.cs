namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomBooking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomBooking()
        {
            RoomCharges = new HashSet<RoomCharge>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomBookingId { get; set; }

        public int? RoomId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RoomBookingDate { get; set; }

        public bool? RoomBookingIsActive { get; set; }

        public int? BookingId { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Room Room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomCharge> RoomCharges { get; set; }
    }
}
