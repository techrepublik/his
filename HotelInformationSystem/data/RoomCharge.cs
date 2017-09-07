namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomCharge
    {
        public int RoomChargeId { get; set; }

        public int? RoomBookingId { get; set; }

        public int? ServiceId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RoomChargeDate { get; set; }

        public double? RoomChargeVatAmt { get; set; }

        public double? RoomChargeServiceAmt { get; set; }

        public double? RoomChargeAmount { get; set; }

        public double? RoomChargeQnty { get; set; }

        public bool? RoomChargeIsActive { get; set; }

        public string RoomChargeNote { get; set; }

        public bool? RoomChargeDiscounted { get; set; }

        [StringLength(50)]
        public string UpdateBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public virtual RoomBooking RoomBooking { get; set; }

        public virtual Service Service { get; set; }
    }
}
