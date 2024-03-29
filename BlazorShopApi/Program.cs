using BlazorShopApi.Context;
using BlazorShopApi.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policy => 
    policy.WithOrigins("http://localhost:5059" ,"https://localhost:7025")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .WithHeaders(Microsoft.Net.Http.Headers.HeaderNames.ContentType)
);

app.UseAuthorization();

app.MapControllers();

app.Run();
