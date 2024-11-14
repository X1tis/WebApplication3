using Microsoft.EntityFrameworkCore;
using BookApp.Data;
using System;

var builder = WebApplication.CreateBuilder(args);
<<<<<<< HEAD
builder.WebHost.UseUrls("https://localhost:7293"); // Замените на нужный порт


// Настраиваем DbContext с использованием SQLite
builder.Services.AddDbContext<AppDbContext>(options =>options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
var app = builder.Build();
app.UseHttpsRedirection(); // Перенаправление на HTTPS
=======

// Настраиваем DbContext с использованием SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();
>>>>>>> 749cea81cfecef3c9f564dd82a9b71fd9247e98f
app.MapControllers();
app.Run();
app.UseDefaultFiles();       // Включает использование index.html по умолчанию
app.UseStaticFiles();        // Включает поддержку статических файлов
app.MapFallbackToFile("index.html");  // Устанавливает index.html как основной файл

