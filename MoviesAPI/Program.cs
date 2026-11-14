using Microsoft.Data.SqlClient;
using MySqlConnector;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IDbConnection>(x =>
    new SqlConnection(builder.Configuration.GetConnectionString("MoviesAdminContext")));

var app = builder.Build();

app.MapControllers();

app.Run();
