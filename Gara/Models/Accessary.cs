namespace Gara.Models
{
    public class Accessary
    {
        public int Id { get; set; }
        public string AccessaryName { get; set; }
        public string AccessaryType { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }
        public bool IsDeleted { get; set; }

        public List<AccessaryPaymentDetail> AccessaryPaymentDetail { get; set; }
    }
}
