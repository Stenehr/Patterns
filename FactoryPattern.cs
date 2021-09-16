namespace Patterns
{
    public class FactoryPattern
    {
        public static void Run()
        {
            var nav = new NavigationBarFactory();
            var dropdown = new DropdownMenuFactory();
        }
    }

    public class NavigationBarFactory
    {
        public Button Button = ButtonFactory.CreateButton();
    }

    public class DropdownMenuFactory
    {
        public Button Button = ButtonFactory.CreateButton();
    }

    public class ButtonFactory
    {
        public static Button CreateButton() => new Button { Type = "Default" };
    }
}
