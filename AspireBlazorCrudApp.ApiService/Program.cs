using Microsoft.EntityFrameworkCore;
using AspireBlazorCrudApp.Database.Data;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();
//i added it why
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//
builder.Services.AddDbContext<AppDbContext>(options =>
{// Configure the DbContext to use SQL Server with the connection string from configuration
    // The connection string is typically defined in appsettings.json or environment variables
    // Replace "DefaultConnection" with the actual name of your connection string
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
   
// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();
//i add it why 
//app.MapControllers();
//i did it why
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty; // 👈 makes Swagger at "/"
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapDefaultEndpoints();

app.Run();

