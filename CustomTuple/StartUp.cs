using System;

namespace CustomTuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string fullName = personInfo[0] + " " + personInfo[1];
            string adress = personInfo[2]; 
            string town = personInfo[3];

            string[] beerInfo = Console.ReadLine().Split();
            string personsName = beerInfo[0];
            int liters = int.Parse(beerInfo[1]);
            bool isDrunk = beerInfo[2] == "drunk" ? true : false; 

            string[] bankInfo = Console.ReadLine().Split();
            string name = bankInfo[0];
            double accountBalance = double.Parse(bankInfo[1]);
            string bankName = bankInfo[2];

            SpecialTuple<string, string, string> personTuple = new SpecialTuple<string, string, string>
                (fullName, adress, town);
            SpecialTuple<string, int, bool> beerTuple = new SpecialTuple<string, int, bool>
                (personsName, liters, isDrunk);
            SpecialTuple<string, double, string> bankTuple = new SpecialTuple<string, double, string>
                (name, accountBalance, bankName);

            Console.WriteLine(personTuple);
            Console.WriteLine(beerTuple);
            Console.WriteLine(bankTuple);
        }
    }
}
