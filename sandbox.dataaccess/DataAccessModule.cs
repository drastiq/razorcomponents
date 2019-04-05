using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace sandbox.dataaccess
{
    public static class DataAccessModule
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=Sandbox.test;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<SandboxContext>(options =>
       options.UseSqlServer(connection));

            return services;
        }
    }
}
