namespace Gara.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Contact { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime StartWorkAt { get; set; }
        public string Religion { get; set; }
        public string IdentificationId { get; set; }
        public string Certificate { get; set; }
        public string Position { get; set; }
        public int SalaryUnit { get; set; }
        public bool IsDeleted { get; set; }
        public List<Identifications> Identifications { get; set; }
    }
}
