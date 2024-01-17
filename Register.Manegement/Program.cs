using Register.Manegement.Application.Application.UserRegister;
using Register.Manegement.Application.Interfaces.UserRegister;
using Register.Manegement.Domain.Service.Interfaces;
using Register.Manegement.Domain.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserRegisterApplication, UserRegisterApplication>();
builder.Services.AddScoped<IUserRegisterService, UserRegisterService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
