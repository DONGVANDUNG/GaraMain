namespace Gara.Models
{
    public class CustomerRepair
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int? RepairTimes { get; set; }
        public int? WarrantyTimes { get; set; }
        public bool IsDeleted { get; set; }

        public Customer Customer { get; set; }
    }
}
