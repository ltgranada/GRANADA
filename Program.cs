//using GranadaITELEC1C.Data;
using GranadaITELEC1C.Services;
//using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IMyFakeDataService, MyFakeDataServices>();
//builder.Services.AddDbContext<AppDbContext>(
    //options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
   // ); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
