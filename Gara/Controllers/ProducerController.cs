using Dapper;
using Gara.ApplicationDbContext;
using Gara.Dto.Producer;
using Gara.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Gara.Controllers
{
    public class ProducerController : BaseController
    {
        private readonly GaraDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public ProducerController(GaraDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        
        [HttpPost("get-producer")]
        public async Task<ActionResult<List<Producer>>> GetPorducer(string producerName, string address, string phoneNumber, string email)
        {
            using SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("default"));
            var query = "EXEC PROC_ADD_PRODUCER @ProducerName, @Address, @PhoneNumber, @Email";
            var producer = await conn.ExecuteAsync(query, new { producerName ,address, phoneNumber, email});
            return Ok(producer);
        }

        [HttpPost("add-producer")]
        public APIResponse AddProducer(CreateProducerDto input)
        {
            try
            {
                SqlParameter[] Parameters =
                {
                    new SqlParameter("@ProducerName", input.ProducerName),
                    new SqlParameter("@Address", input.Address),
                    new SqlParameter("@PhoneNumber", input.PhoneNumber),
                    new SqlParameter("@Email", input.Email)
                };
                var result = _dbContext.Producers.FromSqlRaw("PROC_ADD_PRODUCER @ProducerName, @Address, @PhoneNumber, @Email", Parameters);
                return new APIResponse(result, 200, "OK");
            }
            catch (Exception)
            {
                throw new ArgumentException("Lỗi");
            }
        }


        [HttpGet("get")]
        public async Task<ActionResult<List<Producer>>> GetPorducers()
        {
            using SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("default"));
            var query = "EXEC GetProducer";
            var producer = await conn.QueryAsync(query);
            return Ok(producer);
        }
    }
}
