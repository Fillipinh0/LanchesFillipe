// Cria o builder - substitui o antigo CreateHostBuilder e UseStartup<Startup>()
using LanchesFillipe.Context;
using LanchesFillipe.Models;
using LanchesFillipe.Repositories;
using LanchesFillipe.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Aqui você registra os serviços que a aplicação vai usar
// Equivalente ao método ConfigureServices() do Startup.cs antigo
builder.Services.AddControllersWithViews();
// Registra o DbContext com a string de conexão do appsettings.json
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<ILancheRepository, LancheRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));

builder.Services.AddMemoryCache();
builder.Services.AddSession();


var app = builder.Build();

// Configuração do pipeline HTTP (middleware)
// Equivalente ao método Configure() do Startup.cs antigo
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // página de erro genérica
    app.UseHsts(); // força HTTPS com cabeçalho de segurança
}

app.UseHttpsRedirection(); // redireciona HTTP para HTTPS
app.UseStaticFiles();      // habilita arquivos estáticos (CSS, JS, imagens etc.)

app.UseRouting();          // ativa o sistema de roteamento
app.UseSession();
app.UseAuthorization();    // habilita autenticação/autorização (se houver)

// Define a rota padrão do MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); // Inicia a aplicação
