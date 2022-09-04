using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MainLine.Data;
using MainLine.Data.Services;
using MainLine.Data.Clients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddTransient<ICtaArrivalsHttpClient, CtaArrivalsHttpClient>();
builder.Services.AddTransient<IArrivalService, ArrivalService>();

builder.Services.AddHttpClient<ICtaArrivalsHttpClient, CtaArrivalsHttpClient>(client =>
{
    client.BaseAddress = new Uri("http://lapi.transitchicago.com/api/1.0/ttarrivals.aspx");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
