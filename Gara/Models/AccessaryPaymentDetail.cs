namespace Gara.Models
{
    public class AccessaryPaymentDetail
    {
        public int Id { get; set; }
        public int AccessaryPaymentId { get; set; }
        public int ProducerId { get; set; }
        public int AccessaryId { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public bool IsDeleted { get; set; }
        public AccessaryPayment AccessaryPayment { get; set; }
        public Producer Producer { get; set; }
        public Accessary Accessary { get; set; }
    }
}
