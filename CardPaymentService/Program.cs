using CardPaymentService.Business.Contracts;
using CardPaymentService.Business.Logic;
using CardPaymentService.Data.Contracts;
using CardPaymentService.Data.Logic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICardValidator,CardValidator>();
builder.Services.AddScoped<ITransactionManager, TransactionManager>();
builder.Services.AddScoped<ICardData, CardData>();

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
