using Microsoft.AspNetCore.Mvc;

namespace Gara.Dto.Employee
{
    public class CreateEmployeeDto 
    {
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
        public string Certificate { get; set; }
        public string Position { get; set; }
        public int SalaryUnit { get; set; }
    }
}
