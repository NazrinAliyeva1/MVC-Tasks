var builder = WebApplication.CreateBuilder();
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute("{dafault}", "{controller=Home}/{action=Index}/{id?}");
app.Run();