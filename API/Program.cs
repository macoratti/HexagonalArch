using Application;
using Domain.Entities;
using Infra.Data;
using Infra.Data.Context;
using Infra.Email;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDataBaseInMemoryService();
builder.Services.AddEmailService();
builder.Services.AddApplicationService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

DataInit(app);

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

void DataInit(IApplicationBuilder app)
{
    using (var serviceScope = app.ApplicationServices.CreateScope())
    {
        var context = serviceScope.ServiceProvider.GetService<InMemoryContext>();

        context.Database.EnsureCreated();

        if (!context.Users.Any())
        {
            context.Users.AddRange(
                new User(Guid.NewGuid(), "Maria Silva", "mariasilva@email.com"),
                new User(Guid.NewGuid(), "Paulo Santos", "paulosantos@email.com")
            );
            context.SaveChanges();
        }
    }
}

