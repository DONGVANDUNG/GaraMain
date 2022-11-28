namespace Gara.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Contact { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public bool IsDeleted { get; set; }

        public CustomerRepair CustomerRepair { get; set; }
        public List<VehiclePayment> VehiclePayments { get; set; }
    }
}
