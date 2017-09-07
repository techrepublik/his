namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Amenity
    {
        public int AmenityId { get; set; }

        [StringLength(50)]
        public string AmenityName { get; set; }

        public string AmenityDescription { get; set; }

        public bool? AmenityIsActive { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }
    }
}
