namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookingType
    {
        public int BookingTypeId { get; set; }

        public int? RoomTypeId { get; set; }

        public int? BookingId { get; set; }

        public int? BookingTypeQnty { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
