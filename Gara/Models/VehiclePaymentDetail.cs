namespace Gara.Models
{
    public class VehiclePaymentDetail
    {
        public int Id { get; set; }
        public int VehiclePaymentId { get; set; }
        public int AccessaryId { get; set; }
        public int Amount { get; set; }
        public int AccessaryNumber { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public VehiclePayment VehiclePayment { get; set; }
        public Accessary Accessary { get; set; }
        
    }
}
