using dev.infrasture.Presistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev.infrasture
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddPresistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StudentDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("sql"),
                b => b.MigrationsAssembly(typeof(StudentDbContext).Assembly.FullName)
                ), ServiceLifetime.Transient);

            return services;

        }
    }
}
