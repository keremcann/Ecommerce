using Ecommerce.Application;
using Ecommerce.Dapper;
using Ecommerce.Domain.RepositoriesAsync;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationRegistration();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Dapper
builder.Services.AddScoped<ICustomerRepositoryAsync, CustomerRepositoryAsync>();
#endregion

builder.Services.AddAutoMapper(typeof(ApplicationAutoMapper));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
