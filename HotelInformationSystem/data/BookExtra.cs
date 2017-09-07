namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookExtra
    {
        public int BookExtraId { get; set; }

        public int? BookingExtraId { get; set; }

        public int? BookingId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BookDate { get; set; }

        public int? BookQnty { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public DateTime? UpdatedBy { get; set; }

        public virtual BookingExtra BookingExtra { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
