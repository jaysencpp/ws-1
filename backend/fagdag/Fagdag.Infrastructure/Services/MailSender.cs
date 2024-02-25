using System.Threading.Tasks;
using Fagdag.Domain.Abstractions;

namespace Fagdag.Infrastructure.Services;

// TODO: Open a new tab group and open IMailSender. Switch focus between the tab groups and close the second tab group when done
public class MailSender : IMailSender
{
    public Task SendMail(string mailAddress, string message)
    {
        return Task.CompletedTask;
    }
}