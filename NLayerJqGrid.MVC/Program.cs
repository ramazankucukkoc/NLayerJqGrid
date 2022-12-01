using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using Microsoft.EntityFrameworkCore;
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.DataAccess.Concrete.EntityFramework.Context;
using NLayerJqGrid.MVC.AutoMapper.Profiles;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(UserProfile));
builder.Services.AddDbContext<AppDbContextBase>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon"));
});

builder.Services.AddIdentity<User, Role>(options =>
{
	//User Password Options
	options.Password.RequireDigit = false;
	options.Password.RequiredLength = 7;
	options.Password.RequiredUniqueChars = 2;
	options.Password.RequireNonAlphanumeric = false;
	options.Password.RequireLowercase = false;
	options.Password.RequireUppercase = false;
	//User Username and Email Options
	options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+$";
	options.User.RequireUniqueEmail = true;


}).AddEntityFrameworkStores<AppDbContextBase>();
builder.Services.AddSession();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new AutofacBusinessModule()));

builder.Services.ConfigureApplicationCookie(options =>
{
	options.LoginPath = new PathString("/Users/Login");
	options.LogoutPath = new PathString("/Users/Logout");

	options.Cookie = new CookieBuilder
	{
		Name = "NLayerJqGrid",
		HttpOnly = true,
		SameSite = SameSiteMode.Strict,
		SecurePolicy = CookieSecurePolicy.SameAsRequest
	};

	options.SlidingExpiration = true;
	options.ExpireTimeSpan = System.TimeSpan.FromDays(7);
	options.AccessDeniedPath = new PathString("/Users/AccessDenied");

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Users}/{action=Index}/{id?}");

app.Run();
