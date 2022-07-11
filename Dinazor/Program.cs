//using BlazorApp2.Data;
using Dinazor.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.FileProviders;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

var Service_Configuracion= new DinaupConfiguracionC();
var Service_Cache = new DatosCacheC(Service_Configuracion);
var Service_ControladorDeArchivos = new ControladorDeArchivosC(Service_Configuracion, Service_Cache);


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<DinaupConfiguracionC>(Service_Configuracion);
builder.Services.AddSingleton<DatosCacheC>(Service_Cache);
builder.Services.AddSingleton((ControladorDeArchivosC)Service_ControladorDeArchivos);

builder.Services.AddScoped<HttpContextAccessor>();
builder.Services.AddScoped<Dinazor.DinaupPage>();
builder.Services.AddScoped<DinaNETCore.ASP_NETD.SesionServicio>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<DinaNETCore.ICookie, Cookie>();

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();


//DinaupServidorDeArchivos DinaupServidorDeArchivosX = new();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.Use(async (context, next) =>
{

    await Service_ControladorDeArchivos.ProcesarArchivo(context, next);

});

app.UseRouting();


app.UseStaticFiles();


app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
