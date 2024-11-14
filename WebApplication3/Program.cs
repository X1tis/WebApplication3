using Microsoft.EntityFrameworkCore;
using BookApp.Data;
using System;

var builder = WebApplication.CreateBuilder(args);
<<<<<<< HEAD
builder.WebHost.UseUrls("https://localhost:7293"); // �������� �� ������ ����


// ����������� DbContext � �������������� SQLite
builder.Services.AddDbContext<AppDbContext>(options =>options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
var app = builder.Build();
app.UseHttpsRedirection(); // ��������������� �� HTTPS
=======

// ����������� DbContext � �������������� SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();
>>>>>>> 749cea81cfecef3c9f564dd82a9b71fd9247e98f
app.MapControllers();
app.Run();
app.UseDefaultFiles();       // �������� ������������� index.html �� ���������
app.UseStaticFiles();        // �������� ��������� ����������� ������
app.MapFallbackToFile("index.html");  // ������������� index.html ��� �������� ����

