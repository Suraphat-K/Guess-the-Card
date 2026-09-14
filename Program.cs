using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseDefaultFiles();   // เปิด index.html
app.UseStaticFiles();    // ใช้ wwwroot

app.MapControllers();

app.Run();