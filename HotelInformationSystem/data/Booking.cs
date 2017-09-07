namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            Billings = new HashSet<Billing>();
            BookExtras = new HashSet<BookExtra>();
            BookingTypes = new HashSet<BookingType>();
            CheckInOuts = new HashSet<CheckInOut>();
            RoomBookings = new HashSet<RoomBooking>();
        }

        public int BookingId { get; set; }

        public int? BookingRefNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BookingInFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BookingInTo { get; set; }

        [StringLength(50)]
        public string BookingNote { get; set; }

        public bool? BookingIsActive { get; set; }

        public bool? BookingIsOrigin { get; set; }

        public bool? BookingIsExtended { get; set; }

        public int? BookingExtensionNoDays { get; set; }

        public bool? BookingIsReservation { get; set; }

        public int? GuestId { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billing> Billings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookExtra> BookExtras { get; set; }

        public virtual Guest Guest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingType> BookingTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckInOut> CheckInOuts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomBooking> RoomBookings { get; set; }
    }
}
