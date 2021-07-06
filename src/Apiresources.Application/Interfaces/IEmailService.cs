using Apiresources.Application.DTOs.Email;
using System.Threading.Tasks;

namespace Apiresources.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}