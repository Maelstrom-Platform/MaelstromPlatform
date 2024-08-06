using MaelstromPlatform.API.DbContexts;
using MaelstromPlatform.API.Issue;
using Microsoft.EntityFrameworkCore;

var connStr = Environment.GetEnvironmentVariable("SQLCONNSTR_MaelstromPlatformDev");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(policy =>
{
    policy.AddPolicy("Development", builder =>
        builder.WithOrigins("https://api.maelstromplatform-dev.org")
            .AllowAnyHeader());
});

builder.Services.AddControllers(options =>
{
    options.RespectBrowserAcceptHeader = true;
    options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson()
.AddXmlSerializerFormatters();

builder.Services.AddDbContext<MaelstromContext>(
    dbContextOptions => dbContextOptions.UseSqlServer(connStr));

builder.Services.AddScoped<IIssueRepository, IssueRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("Development");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
