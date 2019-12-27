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
            List<double> messages = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double message = double.Parse(Console.ReadLine());
                messages.Add(message);
            }

            double index = double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>(messages);
            int result = box.GetGreaterThan(index);
            Console.WriteLine(result);

        }
    }
}
