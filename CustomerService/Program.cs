using CustomerService.BAL;
using CustomerService.Context;
using CustomerService.IRepo;
using CustomerService.Repo;
using Microsoft.EntityFrameworkCore;

namespace CustomerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<CustomerIndexView>();
            builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();

            builder.Services.AddDbContext<CustDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));
            builder.Services.AddConsulConfig(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.UseConsul(builder.Configuration);
            app.MapControllers();

            app.Run();
        }
    }
}