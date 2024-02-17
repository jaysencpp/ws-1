using FagdagAPI.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FagdagAPI.Infrastructure;

public static class DependecyInjection
{
   public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
   {
      services.AddDbContext<TodoDbContext>(options => options.UseInMemoryDatabase("TodoDb"));
      return services;
   } 
}