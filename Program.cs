using Microsoft.EntityFrameworkCore;
using MedicalCharlesWembley.Data;

var builder = WebApplication.CreateBuilder(args);

// Thêm dịch vụ DbContext với chuỗi kết nối
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Thêm các dịch vụ MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Cấu hình pipeline
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();