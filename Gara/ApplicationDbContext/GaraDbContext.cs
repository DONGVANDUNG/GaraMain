using Gara.Models;
using Microsoft.EntityFrameworkCore;

namespace Gara.ApplicationDbContext
{
    public class GaraDbContext : DbContext
    {
        public GaraDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Accessary> Accessaries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerRepair> CustomerRepairs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<AccessaryPayment> AccessaryPayments { get; set; }
        public DbSet<AccessaryPaymentDetail> AccessaryPaymentDetails { get; set; }
        public DbSet<VehiclePayment> VehiclePayments { get; set; }
        public DbSet<VehiclePaymentDetail> VehiclePaymentDetails { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<Identifications> Identifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Accessary
            modelBuilder.Entity<Accessary>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.AccessaryName)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.AccessaryType)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.Price)
                .HasColumnType("float")
                .IsRequired();


                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(0)
                .IsRequired();
            });
            #endregion

            #region Customer
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.CustomerName)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.PhoneNumber)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.DateOfBirth)
                .HasColumnType("DateTime");

                entity.Property(e => e.Contact)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.Province)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.District)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.Gender)
                .HasColumnType("bit");

                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(0)
                .IsRequired();
            });
            #endregion

            #region CustomerRepair
            modelBuilder.Entity<CustomerRepair>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(0)
                .IsRequired();
            });
            #endregion

            #region Employee
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.EmployeeCode)
                .HasColumnType("varchar(50)")
                .IsRequired();

                entity.Property(e => e.EmployeeName)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.DateOfBirth)
                .HasColumnType("DateTime")
                .IsRequired();

                entity.Property(e => e.Gender)
                .HasColumnType("bit")
                .IsRequired();

                entity.Property(e => e.District)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false);

                entity.Property(e => e.Province)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false);

                entity.Property(e => e.Contact)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false);

                entity.Property(e => e.PhoneNumber)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false);

                entity.Property(e => e.StartWorkAt)
                .HasColumnType("DateTime")
                .IsRequired();

                entity.Property(e => e.Religion)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false);

                entity.Property(e => e.Certificate)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false);

                entity.Property(e => e.IdentificationId)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.Position)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.SalaryUnit)
                .HasColumnType("int")
                .IsRequired();

                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(0)
                .IsRequired();
            });
            #endregion

            #region Producer
            modelBuilder.Entity<Producer>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.ProducerName)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.Address)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.PhoneNumber)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.Email)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(0)
                .IsRequired();
            });
            #endregion

            #region PaymentType
            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.PaymentTypeName)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(0)
                .IsRequired();
            });
            #endregion

            #region AccessaryPayment
            modelBuilder.Entity<AccessaryPayment>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.TotalAmount)
                .HasColumnType("float")
                .IsRequired();

                entity.Property(e => e.Status)
                .HasColumnType("varchar(200)")
                .IsRequired();

                entity.Property(e => e.Date)
                .HasColumnType("DateTime")
                .IsRequired();

                entity.Property(e => e.Description)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false);

                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(0)
                .IsRequired();
            });
            #endregion

            #region AccessaryPaymentDetail
            modelBuilder.Entity<AccessaryPaymentDetail>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.AccessaryPaymentId)
                .HasColumnType("int")
                .IsRequired();

                entity.Property(e => e.Amount)
                .HasColumnType("int")
                .IsRequired();

                entity.Property(e => e.ProducerId)
                .HasColumnType("int")
                .IsRequired();

                entity.Property(e => e.AccessaryId)
                .HasColumnType("int")
                .IsRequired();

                entity.Property(e => e.Amount)
                .HasColumnType("int")
                .IsRequired();

                entity.Property(e => e.Price)
                .HasColumnType("float")
                .IsRequired();

                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(0)
                .IsRequired();
            });
            #endregion

            #region VehiclePayment
            modelBuilder.Entity<VehiclePayment>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.LicensePlate)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.VehicleBrand)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false); 

                entity.Property(e => e.VehicleType)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false);

                entity.Property(e => e.Date)
                .HasColumnType("DateTime")
                .IsRequired();

                entity.Property(e => e.Status)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.Description)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false);

                entity.Property(e => e.VehicleStatus)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false);

                entity.Property(e => e.CustomerId)
                .HasColumnType("int")
                .HasDefaultValue(0)
                .IsRequired(false);

                entity.Property(e => e.CustomerName)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.TotalPayment)
                .HasColumnType("float")
                .IsRequired();

                entity.Property(e => e.WarantyPeriod)
                .HasDefaultValue(0)
                .HasColumnType("int")
                .IsRequired(false);

                entity.Property(e => e.WarantyPeriodType)
                .HasColumnType("varchar(200)")
                .IsRequired(false);

                entity.Property(e => e.PaymentTypeId)
                .HasColumnType("int")
                .IsRequired();

                entity.Property(e => e.CreatedBy)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.EmployeeFix)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(0)
                .IsRequired();
            });
            #endregion

            #region VehiclePaymentDetail
            modelBuilder.Entity<VehiclePaymentDetail>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.VehiclePaymentId)
                .HasColumnType("int")
                .IsRequired();

                entity.Property(e => e.AccessaryId)
                .HasColumnType("int")
                .IsRequired();

                entity.Property(e => e.Amount)
                .HasColumnType("int")
                .IsRequired();

                entity.Property(e => e.AccessaryNumber)
                .HasColumnType("int")
                .IsRequired();

                entity.Property(e => e.Description)
                .HasColumnType("nvarchar(200)")
                .IsRequired(false);

                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(0)
                .IsRequired();
            });
            #endregion

            #region Error
            modelBuilder.Entity<Error>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.Message)
                .HasColumnType("nvarchar(200)")
                .IsRequired();
            });
            #endregion

            #region Identification
            modelBuilder.Entity<Identifications>(entity =>
            {
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

                entity.Property(e => e.IdentificationType)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.IdentificationNo)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

                entity.Property(e => e.IsDeleted)
                .HasColumnType("bit")
                .HasDefaultValue(0)
                .IsRequired();
            });
            #endregion
        }
    }
}
