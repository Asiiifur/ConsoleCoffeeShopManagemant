using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoffeeShopManagemant
{
  public  class Program
    {
       public static void Main(string[] args)
        {


            int TotalCoffeeCost = 0;

        Start:

            Console.WriteLine("\nSelect Your Coffee Cup Size:\n\nSmall  : 1 [10$] \nMediam : 2 [25$] \nLarge  : 3 [50$]\n");

            int CustomerChoice = int.Parse(Console.ReadLine());

            switch (CustomerChoice)
            {
                case 1:
                    TotalCoffeeCost = 10;

                    break;
                case 2:
                    TotalCoffeeCost += 25;

                    break;

                case 3:
                    TotalCoffeeCost += 50;

                    break;
                default:
                    Console.WriteLine("Your option is Invalid...... Please Select From 1 / 2 / 3 ");

                    goto Start;
            }

        Decide:
            Console.WriteLine("Do You Have Buy Another Coffee - YES or NO ");

            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your Choice {0} Is Invalid  ..Please Try Again ");
                    goto Decide;

            }


            decimal vat = Convert.ToInt32( TotalCoffeeCost * 0.20);
            
           
            Console.WriteLine("Bill Amount  : {0} $", TotalCoffeeCost);

            Console.WriteLine("Vat (20%)    : {0} $ \n", vat );
            Console.WriteLine("------------------------");
            Console.WriteLine("Total Amount : {0} $", vat + TotalCoffeeCost);
            Console.WriteLine( "                              \n\n\n\n\n                        Thank You For Shopping With Us ....\n");
            Console.ReadLine();

        }
    }

}
    