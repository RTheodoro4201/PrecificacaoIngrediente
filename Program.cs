using System.Data;
using MySqlConnector;
using Precificacao.Models;
using Precificacao.Repositories;

var builder = WebApplication.CreateBuilder(args);

string connectionString = @"Server=localhost;Port=3306;
                        Database=cadastrodb;User=root;Password=";

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDbConnection>(sp => new MySqlConnection(connectionString));
builder.Services.AddScoped<IRepository<Ingrediente>, IngredienteRepository>();
builder.Services.AddScoped<IRepository<Compra>, CompraRepository>();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ingrediente}/{action=Index}/{id?}");

app.Run();
