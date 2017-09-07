namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CheckInOut
    {
        public int CheckInOutId { get; set; }

        public int? BookingId { get; set; }

        public DateTime? CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public string CheckInNote { get; set; }

        public string CheckOutNote { get; set; }

        public bool? CheckInOutIsActive { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
