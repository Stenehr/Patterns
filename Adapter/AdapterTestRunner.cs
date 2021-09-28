namespace Patterns.Adapter
{
    public class AdapterTestRunner
    {
        public static void Run()
        {
            var classAdapter = new ClassAdapter();
            var bitcoinEvent = new BitcoinEvent(classAdapter);
            bitcoinEvent.Execute();

            var objAdapter = new ObjectAdapter(new SendGridClientMock());
            var empFiredEvent = new EmployeeFiredEvent(objAdapter);
            empFiredEvent.Execute();
        }
    }
}
