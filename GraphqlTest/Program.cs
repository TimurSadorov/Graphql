using GraphqlTest.Configuration;
using GraphqlTest.Db;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var config = builder.Configuration;

services.AddGraphQLServer()
    .AddGraphqlServices();

services.AddPooledDbContextFactory<AppDbContext>(optionsBuilder =>
    optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseRouting();

app.UseHttpsRedirection();

app.UseEndpoints(route => route.MapGraphQL());

app.Run();