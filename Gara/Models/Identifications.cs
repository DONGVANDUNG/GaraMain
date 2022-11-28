namespace Gara.Models
{
    public class Identifications
    {
        public int Id { get; set; }
        public string IdentificationType { get; set; }
        public string IdentificationNo { get; set; }
        public bool IsDeleted { get; set; }

        public Employee Employee { get; set; }
    }
}
