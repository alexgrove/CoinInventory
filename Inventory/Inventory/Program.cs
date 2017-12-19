using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
       static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
           
        }
        static bool MainMenu()
        {
            List<Coin> coinList = new List<Coin>();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press \"1\" to add a new coin");
            string result = Console.ReadLine();


            if (result == "1")
            {
                Console.WriteLine("You have entered the coin creator");
                Console.Write("Coin Value: ");
                decimal value = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Coin Year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Description: ");
                string description = Console.ReadLine();

                coinList.Add(new Coin { Value = value, Year = year, Description = description });


                Console.WriteLine("Would you like to see the list? y/n:");
                string confirmSeeList = Console.ReadLine();

                if (confirmSeeList == "y")
                {
                    foreach (Coin coin in coinList)
                    {
                        Console.WriteLine(Convert.ToString(coin.Value));
                        Console.WriteLine(Convert.ToString(coin.Year));
                        Console.WriteLine(coin.Description);
                        Console.WriteLine();
                    }

                    Console.ReadLine();
                }
                else
                {
                    MainMenu();
                }

                return true;

            }


            else
            {
                return false;
            }
        }
    }

    class Coin
    {
        public decimal Value { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
    }
}
