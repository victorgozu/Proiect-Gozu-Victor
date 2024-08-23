using Microsoft.EntityFrameworkCore;
using Proiect_Gozu_Victor.Data;
using Proiect_Gozu_Victor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<StudentsRegistryDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentsDb"))
    );
builder.Services.AddScoped<StudentsService>();
builder.Services.AddScoped<AddressesService>();
builder.Services.AddScoped<MarksService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();