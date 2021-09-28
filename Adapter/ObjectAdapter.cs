using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public class ObjectAdapter : IUserNotificationService
    {
        private readonly SendGridClientMock _sendGridClient;

        public ObjectAdapter(SendGridClientMock sendGridClient)
        {
            _sendGridClient = sendGridClient;
        }

        public Task NotifyUser(string userId, string message)
        {
            return _sendGridClient.SendEmailAsync(new SendGridMessage());
        }
    }
}
