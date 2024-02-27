using Fagdag.Domain.Abstractions;
using System.Threading.Tasks;

namespace Fagdag.Infrastructure.Services;

public class MailSenderV2 : IMailSender
{
    public Task SendMail(string mailAddress, string message)
    {
        return Task.CompletedTask;
    }
}
