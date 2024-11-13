using Microsoft.EntityFrameworkCore;
using BookApp.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Настраиваем DbContext с использованием SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
app.UseDefaultFiles();       // Включает использование index.html по умолчанию
app.UseStaticFiles();        // Включает поддержку статических файлов
app.MapFallbackToFile("index.html");  // Устанавливает index.html как основной файл

