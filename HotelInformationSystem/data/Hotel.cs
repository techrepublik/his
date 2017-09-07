namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hotel
    {
        public int HotelId { get; set; }

        public string HotelName { get; set; }

        public string HotelAddress { get; set; }

        public string HotelDescription { get; set; }

        [StringLength(50)]
        public string HotelContactNo { get; set; }

        [StringLength(50)]
        public string HotelRegistrationNo { get; set; }

        [StringLength(50)]
        public string HotelDTINo { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }
    }
}
