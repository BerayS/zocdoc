using AspNetCoreCookieAuthentication.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => {
    options.AccessDeniedPath = "/Account/AccessDenied";
});

builder.Services.AddAuthorization(options => {
    options.AddPolicy("AdminOnly", p => p.RequireClaim(ClaimTypes.Role, "Admin"));
    options.AddPolicy("MustBeDoctor", p => p.RequireClaim(ClaimTypes.Role, "Doctor"));
    options.AddPolicy("MustBeClient", p => p.RequireClaim(ClaimTypes.Role, "Client"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
