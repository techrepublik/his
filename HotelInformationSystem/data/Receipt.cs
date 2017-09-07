namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Receipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receipt()
        {
            PaymentTypes = new HashSet<PaymentType>();
        }

        public int ReceiptId { get; set; }

        public int? BillingId { get; set; }

        public int? ReceiptNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceiptDate { get; set; }

        public double? ReceiptTotalAmt { get; set; }

        public double? ReceiptTenderedAmt { get; set; }

        public double? ReceiptChangeAmt { get; set; }

        public bool? ReceiptIsActive { get; set; }

        public bool? ReceiptIsCancelled { get; set; }

        public int? ReceiptPayModeId { get; set; }

        [StringLength(50)]
        public string UpdateBy { get; set; }

        public DateTime? UpdateOn { get; set; }

        public virtual Billing Billing { get; set; }

        public virtual PaymentMode PaymentMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentType> PaymentTypes { get; set; }
    }
}
