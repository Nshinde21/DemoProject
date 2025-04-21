using Microsoft.EntityFrameworkCore;
using MyApi.Data;
using employeeManagementApi.Repositories;
using employeeManagementApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add services to the container BEFORE builder.Build()
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseNpgsql(connectionString))
builder.Services.AddDbContext<AppDbContext>(options =>
{
    try
    {
        options.UseNpgsql(connectionString);
    }
    catch (Exception ex)
    {
        Console.WriteLine("DB Context Error: " + ex.Message);
        throw;
    }
});

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// ✅ Now build the app
var app = builder.Build();

// Middleware and pipeline configuration
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    // 👇 Redirect root URL to Swagger
    app.MapGet("/", context =>
    {
        context.Response.Redirect("/swagger");
        return Task.CompletedTask;
    });
}

//app.UseAuthorization();
app.MapControllers();
app.UseDeveloperExceptionPage();
app.Run();