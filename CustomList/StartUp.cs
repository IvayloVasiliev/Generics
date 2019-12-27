using System;

namespace CustomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICustomList<string> softUniList = new SoftUniList<string>();

            //•	Add < element > -Adds the given element to the end of the list
            //•	Remove < index > -Removes the element at the given index
            //•	Contains < element > -Prints if the list contains the given element(True or False)
            //•	Swap<index> < index > -Swaps the elements at the given indexes
            //•	Greater < element > -Counts the elements that are greater than the given element and prints their count
            //•	Max - Prints the maximum element in the list
            //•	Min - Prints the minimum element in the list
            //•	Print - Prints all of the elements in the list, each on a separate line

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input.Split();

                string element = string.Empty;

                switch (inputArgs[0])
                {
                    case "Add":
                        element = inputArgs[1];
                        softUniList.Add(element);
                        break;
                    case "Remove":
                        int index = int.Parse(inputArgs[1]);
                        softUniList.Remove(index);
                        break;
                    case "Contains":
                        element = inputArgs[1];
                        Console.WriteLine(softUniList.Contains(element));
                        break;
                    case "Swap":
                        int index1 = int.Parse(inputArgs[1]);
                        int index2 = int.Parse(inputArgs[2]);
                        softUniList.Swap(index1, index2);
                        break;
                    case "Greater":
                        element = inputArgs[1];
                        Console.WriteLine(softUniList.CountGreaterThan(element));
                        break;
                    case "Max":
                        Console.WriteLine(softUniList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(softUniList.Min());
                        break;
                    case "Print":
                        Console.WriteLine(softUniList);
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();
            }

        }
    }
}
