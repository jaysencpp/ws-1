using Fagdag.Domain.Abstractions;
using Fagdag.Infrastructure.Data.Context;
using Fagdag.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Fagdag.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<TodoDbContext>(options => options.UseInMemoryDatabase("TodoDb"));
        services.AddTransient<IMailSender, MailSenderV2>();
        return services;
    }
}
