using InnoXMigration.Api;
using InnoXMigration.Domain.Models;
using MediatR;
using Serilog.Events;
using Serilog;
using System.Reflection;
using FluentValidation.AspNetCore;
using InnoXMigration.Application.Command.HrEmpCommands.UpdateCommand;
using InnoXMigration.Application.Command.HrEmpCommands.GetDataCommand;
using InnoXMigration.Application.Command.HrEmpCommands.DeleteCommand;
using InnoXMigration.Application.Command.HrEmpCommands.CreateCommand;
using InnoXMigration.Application.Command.TaskUpdateCommands.GetByIdCommand;
using InnoXMigration.Application.Command.TaskUpdateCommands.GetAllCommand;
using InnoXMigration.Application.Command.TaskUpdateCommands.CreateTaskCommand;
using InnoXMigration.Application.Command.TaskUpdateCommands.UpdateTaskCommand;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.RegisterMediatR();
        builder.Services.RegisterInfrastructure();
        builder.Services.RegisterServices();
        builder.Services.RegisterDataBase(builder);
        //we register the automapper here 
        builder.Services.AddAutoMapper(typeof(Program)); 

        //Add MediatR here
        //Register HrEmpCommands
        builder.Services.AddMediatR(typeof(GetHrEmpCommand).Assembly);
        builder.Services.AddMediatR(typeof(CreateHrEmpCommand).Assembly);
        builder.Services.AddMediatR(typeof(GetHrEmpCommand).Assembly);
        builder.Services.AddMediatR(typeof(DeleteHrEmpCommand).Assembly);
        builder.Services.AddMediatR(typeof(UpdateHrEmpCommand).Assembly);

        //registering TaskUpdateCommands
        builder.Services.AddMediatR(typeof(GetTaskUpdateByIdCommand).Assembly);
        builder.Services.AddMediatR(typeof(GetAllDataCommand).Assembly);
        builder.Services.AddMediatR(typeof(CreateTaskUpdateCommand).Assembly);
        builder.Services.AddMediatR(typeof(UpdateTaskUpdateCommand).Assembly);

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<DbInnoxContext>();
        
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

        //app.Run();
        try
        {
            Log.Information("Application Is Starting");
            app.Run();

        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Application Failed to start");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}