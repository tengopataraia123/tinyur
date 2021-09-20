using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortener.Data.EF
{
    public static class UrlRepositoryExtension
    {
        public static void AddRepositories(this IServiceCollection service)
        {
            service.AddTransient<IUrlRepository, UrlRepository>();
        }
    }
}
