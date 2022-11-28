namespace Gara.Models
{
    public class PaymentType
    {
        public int Id { get; set; }
        public string PaymentTypeName { get; set; }
        public bool IsDeleted { get; set; }

        public List<VehiclePayment> VehiclePayments { get; set; }
    }
}
