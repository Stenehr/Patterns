using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public class ClassAdapter : SendGridClientMock, IUserNotificationService
    {
        public Task NotifyUser(string userId, string message)
        {
            return SendEmailAsync(new SendGridMessage());
        }
    }
}
