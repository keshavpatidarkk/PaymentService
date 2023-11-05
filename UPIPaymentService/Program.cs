using UPIPaymentService.Business.Contracts;
using UPIPaymentService.Business.Logic;
using UPIPaymentService.Data.Contracts;
using UPIPaymentService.Data.Logic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUPIValidator, UPIValidator>();
builder.Services.AddScoped<ITransactionManager, TransactionManager>();
builder.Services.AddScoped<IUPIAccountData, UPIAccountData>();

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
