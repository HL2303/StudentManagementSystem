// Add these 'using' statements at the top of the file
using Microsoft.EntityFrameworkCore;
using StudentManagement.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// --- 1. Add services to the container. ---

// Get the connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register the ApplicationDbContext with the dependency injection container.
// This tells the application how to connect to the MySQL database.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Configure CORS (Cross-Origin Resource Sharing)
// This is essential to allow your React frontend (running on http://localhost:3000)
// to send requests to this backend.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policyBuilder =>
        {
            policyBuilder.WithOrigins("http://localhost:3000") // The URL of your React app
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// --- 2. Configure the HTTP request pipeline. ---
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Enable the CORS policy you defined above.
// This MUST be placed after UseHttpsRedirection and before UseAuthorization.
app.UseCors("AllowReactApp");

app.UseAuthorization();

app.MapControllers();

app.Run();