using Fiap.Application.AutoMapper;
using Fiap.Application.IoC;
using Fiap.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<FiapContext>(options =>
    options.UseNpgsql("Host=127.0.0.1;Port=5432;Pooling=true;Database=moura;User Id=moura;Password=moura;"));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddResolveDependecies();

builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
