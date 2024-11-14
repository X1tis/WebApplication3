using Microsoft.EntityFrameworkCore;
using BookApp.Data;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:44301"); // �������� �� ������ ����


// ����������� DbContext � �������������� SQLite
builder.Services.AddDbContext<AppDbContext>(options =>options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
var app = builder.Build();
app.UseHttpsRedirection(); // ��������������� �� HTTPS
app.MapControllers();
app.Run();
app.UseDefaultFiles();       // �������� ������������� index.html �� ���������
app.UseStaticFiles();        // �������� ��������� ����������� ������
app.MapFallbackToFile("index.html");  // ������������� index.html ��� �������� ����

