using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public interface IUserNotificationService
    {
        Task NotifyUser(string userId, string message);
    }
}
