using System.Threading.Tasks;

namespace Fagdag.Domain.Abstractions;


//TODO: Go to implementation of interface
public interface IMailSender 
{
    public Task SendMail(string mailAddress, string message);
}