using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodosWebApi.Application.Handlers;
using TodosWebApi.Application.Mapping;
using TodosWebApi.WebApi.Data;
using TodosWebApi.WebApi.Interfaces;
using TodosWebApi.WebApi.Repository;

namespace TodosWebApi.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            const string connectionString = ;

            services.AddDbContext<DataContext>(optionsAction => optionsAction.UseSqlServer(connectionString));
            services.AddTransient<DbContext, DataContext>();
            services.AddScoped<ITodoRepository, TodoRepository>();

            services.AddMediatR(typeof(GetAllTodosHandler).Assembly);

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
