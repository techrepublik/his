namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomStatuses")]
    public partial class RoomStatus
    {
        public int RoomStatusId { get; set; }

        [StringLength(50)]
        public string RoomStatusName { get; set; }
    }
}
