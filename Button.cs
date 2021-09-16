using System;

namespace Patterns
{
    public class Button
    {
        private string _type;
        public string Type
        {
            get => _type;
            set 
            {
                Console.WriteLine(value);
                _type = value;
            }
        }
    }
}
