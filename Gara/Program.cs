using Gara.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var CorsApi = "_corsApiOrigins";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: CorsApi,
                      policy =>
                      {
                          policy.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader();
                      });
});
builder.Services.AddMvc();
builder.Services.AddDbContext<GaraDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("default")));
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("CorsApi");

}

app.UseCors(CorsApi);
app.UseHttpsRedirection();


app.UseAuthorization();
app.MapControllers();

app.Run();
