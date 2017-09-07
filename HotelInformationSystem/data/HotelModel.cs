namespace HotelInformationSystem.data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelModel : DbContext
    {
        public HotelModel()
            : base("name=HotelModel")
        {
        }

        public virtual DbSet<Amenity> Amenities { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<BookExtra> BookExtras { get; set; }
        public virtual DbSet<BookingExtra> BookingExtras { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<BookingType> BookingTypes { get; set; }
        public virtual DbSet<CashInOut> CashInOuts { get; set; }
        public virtual DbSet<CheckInOut> CheckInOuts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<PaymentMode> PaymentModes { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<RoomBooking> RoomBookings { get; set; }
        public virtual DbSet<RoomCategory> RoomCategories { get; set; }
        public virtual DbSet<RoomCharge> RoomCharges { get; set; }
        public virtual DbSet<RoomClean> RoomCleans { get; set; }
        public virtual DbSet<RoomJobOrder> RoomJobOrders { get; set; }
        public virtual DbSet<RoomRatePeriod> RoomRatePeriods { get; set; }
        public virtual DbSet<RoomRate> RoomRates { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomStatus> RoomStatuses { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amenity>()
                .Property(e => e.AmenityName)
                .IsUnicode(false);

            modelBuilder.Entity<Amenity>()
                .Property(e => e.AmenityDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Amenity>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Bank>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<Bank>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Billing>()
                .Property(e => e.BillingNote)
                .IsUnicode(false);

            modelBuilder.Entity<Billing>()
                .Property(e => e.UpdateBy)
                .IsUnicode(false);

            modelBuilder.Entity<BookingExtra>()
                .Property(e => e.BookingExtraName)
                .IsUnicode(false);

            modelBuilder.Entity<BookingExtra>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BookingExtra>()
                .HasMany(e => e.BookExtras)
                .WithOptional(e => e.BookingExtra)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Booking>()
                .Property(e => e.BookingNote)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.BookExtras)
                .WithOptional(e => e.Booking)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.CheckInOuts)
                .WithOptional(e => e.Booking)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.RoomBookings)
                .WithOptional(e => e.Booking)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BookingType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<CashInOut>()
                .Property(e => e.CashInOutBalanceReason)
                .IsUnicode(false);

            modelBuilder.Entity<CashInOut>()
                .Property(e => e.CashInOutOutUserName)
                .IsUnicode(false);

            modelBuilder.Entity<CheckInOut>()
                .Property(e => e.CheckInNote)
                .IsUnicode(false);

            modelBuilder.Entity<CheckInOut>()
                .Property(e => e.CheckOutNote)
                .IsUnicode(false);

            modelBuilder.Entity<CheckInOut>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeMiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeSex)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeCitizenship)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeNote)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.RoomJobOrders)
                .WithOptional(e => e.Employee)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Employee)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Guest>()
                .Property(e => e.GuestLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.GuestMiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.GuestFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.GuestCompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.GuestCitizenship)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.GuestSex)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.GuestAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.GuestNote)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .HasMany(e => e.Bookings)
                .WithOptional(e => e.Guest)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Guest>()
                .HasMany(e => e.Reservations)
                .WithOptional(e => e.Guest)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Hotel>()
                .Property(e => e.HotelName)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.HotelAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.HotelDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.HotelContactNo)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.HotelRegistrationNo)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.HotelDTINo)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMode>()
                .Property(e => e.PaymentModeName)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMode>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentMode>()
                .HasMany(e => e.Receipts)
                .WithOptional(e => e.PaymentMode)
                .HasForeignKey(e => e.ReceiptPayModeId);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.PaymentTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.PaymentTypeRefNo)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.PaymentTypeSAmount)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.UpdateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .HasMany(e => e.PaymentTypes)
                .WithOptional(e => e.Receipt)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Reservation>()
                .Property(e => e.ReservationRequest)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.ReservationNote)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<RoomBooking>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<RoomBooking>()
                .HasMany(e => e.RoomCharges)
                .WithOptional(e => e.RoomBooking)
                .WillCascadeOnDelete();

            modelBuilder.Entity<RoomCategory>()
                .Property(e => e.RoomCategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<RoomCategory>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<RoomCharge>()
                .Property(e => e.RoomChargeNote)
                .IsUnicode(false);

            modelBuilder.Entity<RoomCharge>()
                .Property(e => e.UpdateBy)
                .IsUnicode(false);

            modelBuilder.Entity<RoomClean>()
                .Property(e => e.RoomCleanNote)
                .IsUnicode(false);

            modelBuilder.Entity<RoomClean>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<RoomJobOrder>()
                .Property(e => e.JobOrderDescription)
                .IsUnicode(false);

            modelBuilder.Entity<RoomJobOrder>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<RoomJobOrder>()
                .HasMany(e => e.RoomCleans)
                .WithOptional(e => e.RoomJobOrder)
                .WillCascadeOnDelete();

            modelBuilder.Entity<RoomRatePeriod>()
                .Property(e => e.RoomRatePeriodCode)
                .IsUnicode(false);

            modelBuilder.Entity<RoomRatePeriod>()
                .Property(e => e.RoomRatePeriodDescription)
                .IsUnicode(false);

            modelBuilder.Entity<RoomRatePeriod>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<RoomRatePeriod>()
                .HasMany(e => e.RoomRates)
                .WithOptional(e => e.RoomRatePeriod)
                .WillCascadeOnDelete();

            modelBuilder.Entity<RoomRate>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.RoomNo)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.RoomDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.RoomCleans)
                .WithOptional(e => e.Room)
                .WillCascadeOnDelete();

            modelBuilder.Entity<RoomStatus>()
                .Property(e => e.RoomStatusName)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.RoomTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserNote)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CashInOuts)
                .WithOptional(e => e.User)
                .WillCascadeOnDelete();
        }
    }
}
