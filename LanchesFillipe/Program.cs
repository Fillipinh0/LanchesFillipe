// Cria o builder - substitui o antigo CreateHostBuilder e UseStartup<Startup>()
using LanchesFillipe.Context;
using LanchesFillipe.Models;
using LanchesFillipe.Repositories;
using LanchesFillipe.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Aqui voc� registra os servi�os que a aplica��o vai usar
// Equivalente ao m�todo ConfigureServices() do Startup.cs antigo
builder.Services.AddControllersWithViews();
// Registra o DbContext com a string de conex�o do appsettings.json
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<ILancheRepository, LancheRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));

builder.Services.AddMemoryCache();
builder.Services.AddSession();


var app = builder.Build();

// Configura��o do pipeline HTTP (middleware)
// Equivalente ao m�todo Configure() do Startup.cs antigo
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // p�gina de erro gen�rica
    app.UseHsts(); // for�a HTTPS com cabe�alho de seguran�a
}

app.UseHttpsRedirection(); // redireciona HTTP para HTTPS
app.UseStaticFiles();      // habilita arquivos est�ticos (CSS, JS, imagens etc.)

app.UseRouting();          // ativa o sistema de roteamento
app.UseSession();
app.UseAuthorization();    // habilita autentica��o/autoriza��o (se houver)

// Define a rota padr�o do MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); // Inicia a aplica��o
