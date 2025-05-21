using BarbeariaAgenda.Data;
using BarbeariaAgenda.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ? Registra o contexto correto (BarbeariaContext)
builder.Services.AddDbContext<BarbeariaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware padrão
app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();

app.Run();
