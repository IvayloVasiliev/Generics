using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> messages = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                messages.Add(message);
            }

            string index = Console.ReadLine();

            Box<string> box = new Box<string>(messages);
            int result = box.GetGreaterThan(index);
            Console.WriteLine(result);

        }
    }
}
