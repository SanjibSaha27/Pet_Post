using PetPost.Models;
using Amazon.S3;
using Amazon.Extensions.NETCore.Setup;
using PetPost.Controllers;

var builder = WebApplication.CreateBuilder(args);

// 1. Configure AWS section before calling Build()
builder.Services.Configure<AwsSettings>(builder.Configuration.GetSection("AWS"));
builder.Services.AddDefaultAWSOptions(builder.Configuration.GetAWSOptions());
builder.Services.AddAWSService<IAmazonS3>();

// 2. Add MVC support
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 3. Middleware & Routing
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pet}/{action=Index}/{id?}"
);

app.Run();
