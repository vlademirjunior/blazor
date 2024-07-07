using FrontEnd.ContainerDI;
using FrontEnd.Data;

var builder = WebApplication.CreateBuilder(args);

// Here, AddRazorPages and AddServerSideBlazor register Razor Pages and Blazor services to the DI container. (DI - Dependency Injection)
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Registering the service
builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddSingleton<ISingletonService, SingletonService>();

// Other way to register Services in DI Container:
builder.Services.AddHttpClient<WeatherForecastClient>(c =>
{
    var url = builder.Configuration["WEATHER_URL"] 
        ?? throw new InvalidOperationException("WEATHER_URL is not set");

    c.BaseAddress = new(url);
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
