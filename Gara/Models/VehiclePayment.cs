namespace Gara.Models
{
    public class VehiclePayment
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string VehicleType { get; set; }
        public string VehicleBrand { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string VehicleStatus { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public float TotalPayment { get; set; }
        public int? WarantyPeriod { get; set; } //Thời hạn bảo hành
        public string WarantyPeriodType { get; set; } //Loại thời hạn bảo hành  (D,M,Y)
        public int? PaymentTypeId { get; set; }
        public string CreatedBy { get; set; }
        public string EmployeeFix { get; set; }
        public bool IsDeleted { get; set; }
        public Customer Customer { get; set; }
        public List<VehiclePaymentDetail> VehiclePaymentDetails { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
