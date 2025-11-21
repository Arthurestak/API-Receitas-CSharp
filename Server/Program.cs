var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.UseStaticFiles();

// 2. Permite servir o Blazor Framework files (componentes Blazor)
app.UseBlazorFrameworkFiles();

// ... (o código original do UseAuthorization, etc., fica aqui)

// 3. Define a rota de fallback para o index.html do Client
app.MapFallbackToFile("index.html");

app.Run();

