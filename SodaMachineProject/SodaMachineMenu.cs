using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class SodaMachineMenu
    {
        public bool runSodaMachine = true;
        public int choice;
        public SodaMachine sodaMachine;
        public Payment pay;
        public SodaMachineMenu()
        {
            sodaMachine = new SodaMachine();
            pay = new Payment();

            
            Console.WriteLine("");
            runSodaMachineMenu();
        }

        public void runSodaMachineMenu()
        {
         
            while (runSodaMachine)
            {
                Console.WriteLine("Welcome to My DevCode Soda Machine");

                Console.WriteLine("Please Choose from the list of drinks we have...");
                Console.WriteLine("(1)********Grape Soda********(1)");
                Console.WriteLine("(2)********Orange Soda*******(2)");
                Console.WriteLine("(3)*********Meat Soda********(3)");
                Console.WriteLine("(4)**List Soda Machine Inventory**(4)");
                Console.WriteLine("(5)******Display Soda List********");
                Console.WriteLine("(6)******Display Coin List********");
                Console.WriteLine("(0)*******EXIT MACHINE*******");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        sodaMachine.buyGrapeSoda(pay.payForDrink());
                        break;
                    case 2:
                        sodaMachine.buyOrangeSoda(pay.payForDrink());
                        break;
                    case 3:
                        sodaMachine.buyMeatSoda(pay.payForDrink());
                        break;
                    case 4:
                        Console.WriteLine(sodaMachine.ToString());
                        break;
                    case 5:
                        foreach (Soda soda in sodaMachine.sodas)
                        {
                            Console.WriteLine(soda.ToString());
                        }
                        break;
                    case 6:
                        foreach (Coin coin in sodaMachine.coins)
                        {
                            Console.WriteLine(coin.ToString());
                        }
                        break;
                    case 0:
                        runSodaMachine = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid choice until we add more drinks");
                        runSodaMachineMenu();
                        break;
                }
            }
        }
    }
}
