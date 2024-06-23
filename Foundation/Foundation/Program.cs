using Foundation;
using Foundation.Anomalies;
using Foundation.Researchers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FoundationContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IAnomalyRepository, AnomalyRepository>();
builder.Services.AddScoped<IResearcherRepository, ResearcherRepository>();
builder.Services.AddTransient<IAnomalyService, AnomalyService>();
builder.Services.AddTransient<IResearcherService, ResearcherService>();

builder.Services.AddEndpointsApiExplorer();
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