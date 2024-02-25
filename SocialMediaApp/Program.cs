
using Domain_Layer;
using Domain_Layer.AutoMapper.Profiles;
using Domain_Layer.Exceptions;
using Infrastructure_Layer;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Service_Layer.ServiceAbstraction;
using Service_Layer.Service;
using Serilog;
using Serilog.Settings.Configuration;

namespace SocialMediaApp
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
            builder.Services.AddAutoMapper(new[] { typeof(UserProfile).Assembly });

            builder.Services.AddDbContext<SocialMediaContext>(options =>
            options.UseSqlServer(
                     builder.Configuration.GetConnectionString("DB")));

            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config).CreateLogger();


            builder.Host.UseSerilog();

            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>(); 
            builder.Services.AddTransient<IServiceManager, ServiceManager>();
            builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
            builder.Services.AddProblemDetails();

            try
            {
                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }
                app.UseExceptionHandler();

                app.UseHttpsRedirection();

                app.UseAuthorization();


                app.MapControllers();


                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }

           
        }
    }
}
