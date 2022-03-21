using Microsoft.EntityFrameworkCore;
using TaxiBookingAPI;
using TaxiBookingAPI.Models;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins().AllowAnyHeader().AllowAnyOrigin();
                      });
});

builder.Services.AddControllers();
builder.Services.AddDbContext<BookingContext>(opt =>
    opt.UseInMemoryDatabase("BookingList"));

builder.Services.AddSingleton<ILocationServices, LocationServices>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
