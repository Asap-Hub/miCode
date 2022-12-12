using InnoXMigration.Application;
using InnoXMigration.Application.OtherService.Implementation;
using InnoXMigration.Application.OtherService.Interface;
using InnoXMigration.Domain.Models;
using InnoXMigration.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog.Events;
using Serilog;
using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using InnoXMigration.Application.Dtos;
using InnoXMigration.Application.Interface.HrEmp;
using InnoXMigration.Infrastructure.Services.HrEmp;
using InnoXMigration.Application.Command.HrEmpCommands.CreateCommand;
using InnoXMigration.Application.Interface.Task;
using InnoXMigration.Infrastructure.Services.TaskUpdate;

namespace InnoXMigration.Api
{
    public static class ServiceCollectionExtension
    {
           public static IServiceCollection RegisterInfrastructure(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IDateTimeService, DateTimeService>();
            return serviceCollection;
        }

        //MediatR
        public static IServiceCollection RegisterMediatR(this IServiceCollection serviceCollections)
        {
            var assembly = Assembly.GetExecutingAssembly(); 
            return serviceCollections.AddMediatR(assembly);
        }


        public static IServiceCollection RegisterServices(this IServiceCollection serviceCollection)
        {
             Log.Logger = new LoggerConfiguration()
            .WriteTo.Console(
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
            restrictedToMinimumLevel: LogEventLevel.Information
            )
        .WriteTo.File(
            path: "../logs/webapi-.log",
            outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
            rollingInterval: RollingInterval.Day,
            restrictedToMinimumLevel: LogEventLevel.Information
        ).CreateLogger();
            

            //registering your services here.
            serviceCollection.AddScoped(typeof(IBaseService<>), typeof(BaseService<>)); 
            serviceCollection.AddScoped(typeof(IHrEmp<>), typeof(HrEmpService<>));
            serviceCollection.AddScoped<IUnitOfWork,UnitOfWork>();
            serviceCollection.AddScoped<ITaskUpdate, TaskUpdateService>();
            //registering fluentvalidation in the program.cs file
            serviceCollection.AddFluentValidationAutoValidation( fv => { 
                //disabling other validators including data anotations.
            fv.DisableDataAnnotationsValidation = true; 
            });
            //registering your validator class.
            serviceCollection.AddValidatorsFromAssemblyContaining<CreateHrEmpCommandValidator>();
           
            
            return serviceCollection;
        }

        public static IServiceCollection RegisterDataBase(this IServiceCollection serviceCollection, WebApplicationBuilder builder)
        {

            serviceCollection.AddDbContext<DbInnoxContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            return serviceCollection;
        }
         
    }
}
