using Microsoft.AspNetCore.Mvc;

namespace Gara.Dto.Producer
{
    public class CreateProducerDto
    {
        public string ProducerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
