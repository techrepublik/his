namespace HotelInformationSystem.data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            RoomJobOrders = new HashSet<RoomJobOrder>();
            Users = new HashSet<User>();
        }

        public int EmployeeId { get; set; }

        public int? EmployeeIdNo { get; set; }

        [StringLength(50)]
        public string EmployeeLastName { get; set; }

        [StringLength(50)]
        public string EmployeeFirstName { get; set; }

        [StringLength(50)]
        public string EmployeeMiddleName { get; set; }

        [StringLength(50)]
        public string EmployeeSex { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EmployeeBirthDate { get; set; }

        public string EmployeeAddress { get; set; }

        [StringLength(50)]
        public string EmployeeCitizenship { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EmployeeDateHired { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EmployeeDateEnded { get; set; }

        [Column(TypeName = "image")]
        public byte[] EmployeePicture { get; set; }

        public bool? EmployeeIsActive { get; set; }

        public string EmployeeNote { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomJobOrder> RoomJobOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
