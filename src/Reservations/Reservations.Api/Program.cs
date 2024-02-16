using Reservations.Infrastructure;
using Reservations.Core;
using Reservations.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services
	.AddCore()
	.AddApplication()
	.AddInfrastructure(builder.Configuration)
	.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//	app.UseSwagger();
//	app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();
app.UseInfrastructure();

app.MapControllers();

app.Run();
