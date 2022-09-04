using MainLine.Data;
using MainLine.Data.Services;
using MainLine.Data.Clients;

var builder = WebApplication.CreateBuilder(args);

var ctaClientConfig = builder.Configuration.GetSection(nameof(CtaClientConfig)).Get<CtaClientConfig>();
builder.Configuration.Bind(nameof(CtaClientConfig), ctaClientConfig);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddTransient<ICtaHttpClient, CtaHttpClient>();
builder.Services.AddTransient<IArrivalService, ArrivalService>();
builder.Services.AddSingleton(ctaClientConfig);

builder.Services.AddHttpClient<ICtaHttpClient, CtaHttpClient>(client =>
{
    client.BaseAddress = new Uri(ctaClientConfig.BaseUrl);
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
