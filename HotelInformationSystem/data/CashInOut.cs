namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CashInOut
    {
        public int CashInOutId { get; set; }

        public int? UserId { get; set; }

        public DateTime? CashInOutDate { get; set; }

        public double? CashInOutInitAmount { get; set; }

        public double? CashInOutOutAmount { get; set; }

        public bool? CashInOutIsActive { get; set; }

        public double? CashInOutBalanceAmount { get; set; }

        public string CashInOutBalanceReason { get; set; }

        [StringLength(50)]
        public string CashInOutOutUserName { get; set; }

        public DateTime? CashInOutOutDate { get; set; }

        public virtual User User { get; set; }
    }
}
