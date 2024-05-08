using ProniaTask.DataAccesLayer;

var builder = WebApplication.CreateBuilder();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProniaContext>();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute("{dafault}", "{controller=Home}/{action=Index}/{id?}");
app.Run();