namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomClean
    {
        public int RoomCleanId { get; set; }

        public int? RoomId { get; set; }

        public int? JobOrderId { get; set; }

        public bool? RoomCleanIsClean { get; set; }

        public bool? RoomCleanIsCleaning { get; set; }

        public string RoomCleanNote { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public virtual RoomJobOrder RoomJobOrder { get; set; }

        public virtual Room Room { get; set; }
    }
}
