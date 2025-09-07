using Microsoft.EntityFrameworkCore;
using AspireBlazorCrudApp.Database.Data;
using AspireBlazorCrudApp.BL.Services;
using AspireBlazorCrudApp.BL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

//i added it why
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Entity Framework Core with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
{// Configure the DbContext to use SQL Server with the connection string from configuration
    // The connection string is typically defined in appsettings.json or environment variables
    // Replace "DefaultConnection" with the actual name of your connection string
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


// Register the ProductService and ProductRepository for dependency injection
builder.Services.AddScoped<IProductService , ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();


// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

// Enable middleware to serve generated Swagger as a JSON endpoint and the Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty; // 👈 makes Swagger at "/"
    });
}

// Enforce HTTPS redirection and authorization middleware
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapDefaultEndpoints();

app.Run();

