using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependecyResolvers
{
    public static class ServiceTools
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonDal, EfPersonDal>();
            services.AddScoped<IPersonService, PersonManager>();
        }
    }
}
