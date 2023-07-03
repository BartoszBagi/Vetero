using System.Reflection;
using Vetero.Persistance;
using Vetero.Application;
using Vetero.Infrastructure;
using log4net.Config;
using log4net;
using Vetero.Application.Common.Helpers;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOptions();
builder.Services.Configure<AppSettings>(
builder.Configuration.GetSection("AppSettings"));
// Add services to the container.
var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
XmlConfigurator.Configure(logRepository, new FileInfo("log4netconfig.config"));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructure();
builder.Services.AddPersistance(builder.Configuration);
builder.Services.AddApplication();
var app = builder.Build();

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
