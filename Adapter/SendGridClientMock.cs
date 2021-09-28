using System;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public class SendGridClientMock
    {
        public Task SendEmailAsync(SendGridMessage message)
        {
            Console.WriteLine("Sending email");
            return Task.CompletedTask;
        }
    }

    public class SendGridMessage
    {
        public SendGridMessage()
        {
            Console.WriteLine("message");
        }
    }
}
