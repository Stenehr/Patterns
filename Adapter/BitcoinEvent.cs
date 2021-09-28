using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public class BitcoinEvent
    {
        private readonly IUserNotificationService _userNotificationService;

        public BitcoinEvent(IUserNotificationService userNotificationService)
        {
            _userNotificationService = userNotificationService;
        }

        public Task Execute()
        {
            // work

            return _userNotificationService.NotifyUser("", "");
        }
    }
}
