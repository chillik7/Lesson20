using WatchlistApp.Services; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IWatchlistService, WatchlistService>();

builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Watchlist}/{action=Index}/{id?}");

app.Run();
