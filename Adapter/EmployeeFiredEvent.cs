using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public class EmployeeFiredEvent
    {
        private readonly IUserNotificationService _userNotificationService;

        public EmployeeFiredEvent(IUserNotificationService userNotificationService)
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
