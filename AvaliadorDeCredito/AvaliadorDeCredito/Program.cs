using AvaliadorDeCredito.DataBase;
using AvaliadorDeCredito.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region Configure Services

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer(
        "Data Source=LAPTOP-TATUSV7C;Initial Catalog=AVALIADOR_CREDITO;Integrated Security=True"));

builder.Services.AddSwaggerGen();

var app = builder.Build();

#endregion

#region Swagger

app.UseSwagger();

app.UseSwaggerUI();

#endregion

#region Action

app.MapClienteEndPoints();

app.Run();

#endregion
