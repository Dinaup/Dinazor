//using BlazorApp2.Data;
using Dinazor.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.FileProviders;
using Radzen;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var Service_Configuracion = new DinaupConfiguracionC();
var Service_Cache = new DatosCacheC(Service_Configuracion);


builder.Services.AddControllers();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<DinaupConfiguracionC>(Service_Configuracion);
builder.Services.AddSingleton<DatosCacheC>(Service_Cache);
builder.Services.AddSingleton<DinaNetCore.NET_Servicio_FirmaURLC>(Service_Configuracion.FirmadorURLArchivos );


//builder.Services.AddSingleton((ControladorDeArchivosC)Service_ControladorDeArchivos);
//builder.Services.AddSingleton<ControladorDeArchivos>();

builder.Services.AddScoped<HttpContextAccessor>();
builder.Services.AddScoped<Dinazor.DinaupPage>();
builder.Services.AddScoped<DinaNetCore.ASP_NETD.SesionServicio>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<DinaNetCore.ICookie, Cookie>();

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();




//var assembly = typeof(DinaNetCore.ControladorDeArchivosC).GetTypeInfo().Assembly;
//// This creates an AssemblyPart, but does not create any related parts for items such as views.
//var part = new AssemblyPart(assembly);
//builder.Services.AddControllers().ConfigureApplicationPartManager(apm => apm.ApplicationParts.Add(part));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//app.Use(async (context, next) =>
//{

//    await Service_ControladorDeArchivos.ProcesarArchivo(context, next);

//});

app.UseRouting();


app.UseStaticFiles();


app.UseRouting();
app.MapControllers();


app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
