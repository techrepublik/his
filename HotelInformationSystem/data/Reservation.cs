namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        public int ReservationId { get; set; }

        public int? GuestId { get; set; }

        public DateTime? ReservationDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReservationDateFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReservationDateTo { get; set; }

        public string ReservationRequest { get; set; }

        public string ReservationNote { get; set; }

        public bool? ReservationIsBooked { get; set; }

        public bool? ReservationIsActive { get; set; }

        public bool? ReservationIsCancel { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Guest Guest { get; set; }
    }
}
