namespace Patterns
{
    public class AbstractFactoryPattern
    {
        public static void Run()
        {
            new NavigationBarAbstractFactory(new Apple());
            new DropdownMenuAbstractFactory(new Android());
        }
    }

    public class NavigationBarAbstractFactory
    {
        public Button Button { get; }
        public NavigationBarAbstractFactory(IUIFactory uiFactory) => Button = uiFactory.CreateButton();
    }

    public class DropdownMenuAbstractFactory
    {
        public Button Button { get; }
        public DropdownMenuAbstractFactory(IUIFactory uiFactory) => Button = uiFactory.CreateButton();
    }

    public interface IUIFactory
    {
        public Button CreateButton();
    }

    public class Apple : IUIFactory
    {
        public Button CreateButton() => new Button { Type = "IOS button" };
    }

    public class Android : IUIFactory
    {
        public Button CreateButton() => new Button { Type = "Android button" };
    }
}
