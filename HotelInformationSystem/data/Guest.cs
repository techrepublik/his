namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Guest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Guest()
        {
            Bookings = new HashSet<Booking>();
            Reservations = new HashSet<Reservation>();
        }

        public int GuestId { get; set; }

        public int? GuestNo { get; set; }

        [StringLength(50)]
        public string GuestLastName { get; set; }

        [StringLength(50)]
        public string GuestMiddleName { get; set; }

        [StringLength(50)]
        public string GuestFirstName { get; set; }

        [StringLength(50)]
        public string GuestCompanyName { get; set; }

        [StringLength(50)]
        public string GuestCitizenship { get; set; }

        [StringLength(50)]
        public string GuestSex { get; set; }

        [Column(TypeName = "date")]
        public DateTime? GuestBirthDate { get; set; }

        public string GuestAddress { get; set; }

        public string GuestNote { get; set; }

        public bool? GuestIsActive { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public DateTime? UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
