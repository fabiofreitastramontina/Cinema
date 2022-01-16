using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Cinema.WebApi.Infraestrutura.Mappers;

namespace Cinema.WebApi.Hosting.Extensions
{
    public static class DapperExtensions
    {
        public static IServiceCollection AddDapper(this IServiceCollection serviceCollection)
        {
            SqlMapper.AddTypeHandler(new GuidTypeHandler());
            return serviceCollection;
        }
    }
}
