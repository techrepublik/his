namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomRate
    {
        public int RoomRateId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RoomRateDate { get; set; }

        public double? RoomRatePrice { get; set; }

        public int? RoomRatePeriodId { get; set; }

        public int? RoomTypeId { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual RoomRatePeriod RoomRatePeriod { get; set; }

        public virtual RoomType RoomType { get; set; }
    }
}
