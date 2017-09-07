namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaymentType
    {
        public int PaymentTypeId { get; set; }

        public int? PaymentModeId { get; set; }

        public string PaymentTypeName { get; set; }

        public string PaymentTypeRefNo { get; set; }

        public double? PaymentTypeAmount { get; set; }

        public string PaymentTypeSAmount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PaymentTypeDateDue { get; set; }

        public int? BankId { get; set; }

        public int? ReceiptId { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Bank Bank { get; set; }

        public virtual Receipt Receipt { get; set; }
    }
}
