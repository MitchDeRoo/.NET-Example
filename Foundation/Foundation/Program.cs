using Foundation.Controllers;
using Foundation.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IAnomalyService, AnomalyService>();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

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