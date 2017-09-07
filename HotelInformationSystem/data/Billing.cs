namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Billing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Billing()
        {
            Receipts = new HashSet<Receipt>();
        }

        public int BillingId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BillingDate { get; set; }

        public double? BillingAmount { get; set; }

        public double? BillingVatAmt { get; set; }

        public double? BillingServiceAmt { get; set; }

        public double? BillingDiscountAmt { get; set; }

        public bool? BillingIsActive { get; set; }

        public string BillingNote { get; set; }

        public int? BookingId { get; set; }

        public int? GuestId { get; set; }

        [StringLength(50)]
        public string UpdateBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public virtual Booking Booking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
