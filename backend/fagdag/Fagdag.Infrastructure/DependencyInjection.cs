using Fagdag.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Fagdag.Infrastructure;

public static class DependencyInjection
{
   public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
   {
      services.AddDbContext<TodoDbContext>(options => options.UseInMemoryDatabase("TodoDb"));
      return services;
   } 
}