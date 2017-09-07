namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            RoomBookings = new HashSet<RoomBooking>();
            RoomCleans = new HashSet<RoomClean>();
        }

        public int RoomId { get; set; }

        [StringLength(50)]
        public string RoomNo { get; set; }

        public string RoomDescription { get; set; }

        [Column(TypeName = "image")]
        public byte[] RoomPicture { get; set; }

        public bool? RoomIsActive { get; set; }

        public int? RoomTypeId { get; set; }

        public int? RoomCategoryId { get; set; }

        public int? RoomFloor { get; set; }

        public bool? RoomIsOccupied { get; set; }

        public bool? RoomIsCleaned { get; set; }

        public bool? RoomIsReserved { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomBooking> RoomBookings { get; set; }

        public virtual RoomCategory RoomCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomClean> RoomCleans { get; set; }

        public virtual RoomType RoomType { get; set; }
    }
}
