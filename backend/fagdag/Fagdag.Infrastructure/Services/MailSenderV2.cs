using System.Threading.Tasks;
using Fagdag.Domain.Abstractions;

namespace Fagdag.Infrastructure.Services;

public class MailSenderV2 : IMailSender
{
    public Task SendMail(string mailAddress, string message)
    {
        return Task.CompletedTask;
    }
}