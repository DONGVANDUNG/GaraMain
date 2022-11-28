namespace Gara.Models
{
    public class AccessaryPayment
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public float TotalAmount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

        public List<AccessaryPaymentDetail> AccessaryPaymentDetails { get; set; }

    }
}
