using Rooster.Lottery.Repository.In_memory_Repository;
using Rooster.Lottery.Services.@interface;
using Rooster.Lottery.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<ILotteryResultRepository, LotteryResultRepository>();
builder.Services.AddSingleton<IPlayerRepository, PlayerRepository>();
builder.Services.AddSingleton<IBetRepository, BetRepository>();

builder.Services.AddScoped<ILotteryResultService, LotteryResultService>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IBetService, BetService>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
