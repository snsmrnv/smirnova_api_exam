using Microsoft.EntityFrameworkCore;
using smirnovas.Data;
using System.Text.Json.Serialization.Metadata;

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы в контейнер
builder.Services.AddDbContext<TaskContext>(opt => opt.UseInMemoryDatabase("TaskDB"));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.TypeInfoResolver = new DefaultJsonTypeInfoResolver();
    });
var app = builder.Build();

// Настройка HTTP pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();