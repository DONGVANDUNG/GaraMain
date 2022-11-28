namespace Gara.Dto.Producer
{
    public class ProducerDto
    {
        public int Id { get; set; }
        public string ProducerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}
