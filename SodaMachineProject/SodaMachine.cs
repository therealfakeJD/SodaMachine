using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace SodaMachineProject
{
    public class SodaMachine
    {
        GrapeSoda grape = new GrapeSoda();
        OrangeSoda orange = new OrangeSoda();
        MeatSoda meat = new MeatSoda();
        Quarter quarter = new Quarter();
        Dime dime = new Dime();
        Nickel nickel = new Nickel();
        Penny penny = new Penny();
        public Payment pay = new Payment();
        List<Coin> payList;
        public List<Coin> coins;
        public List<Soda> sodas;
        public double totalSodaMachineChange;
        public int totalSodasInMachine;
        public int grapeSodasLeft;
        public int orangeSodasLeft;
        public int meatSodasLeft;
        
      
        public SodaMachine()
        {
            
            totalSodaMachineChange = 0;
            totalSodasInMachine = 0;
            coins = new List<Coin>();
            sodas = new List<Soda>();
            payList = pay.payList;
            fillInitChange();
            fillInitSoda();
          

        }

        public void fillInitChange()
        {
            for (int i = 0; i < 20; i++)
            {
                coins.Add(quarter);
                totalSodaMachineChange += quarter.value;
            }

            for (int i = 0; i < 10; i++)
            {
                coins.Add(dime);
                totalSodaMachineChange += dime.value;
            }

            for (int i = 0; i < 20; i++)
            {
                coins.Add(nickel);
                totalSodaMachineChange += nickel.value;
            }

            for (int i = 0; i < 50; i++)
            {
                coins.Add(penny);
                totalSodaMachineChange += penny.value;
            }

           }

        public void fillInitSoda()
        {
            for (int i = 0; i < 10; i++)
            {
                sodas.Add(grape);
                grapeSodasLeft += grape.soda;
            }

            for (int i = 0; i < 10; i++)
            {
                sodas.Add(orange);
                orangeSodasLeft += orange.soda;
            }

            for (int i = 0; i < 10; i++)
            {
                sodas.Add(meat);
                meatSodasLeft += meat.soda;
               
            }
            totalSodasInMachine = sodas.Count;
        }


        public Soda buyGrapeSoda(List<Coin> payList, double payListValue)
        {
           
            if (grape.sodaCost == pay.payListValue)
            {
                totalSodaMachineChange += pay.payListValue;
                foreach (Coin coin in payList)
                {
                    Console.WriteLine(coin);
                }
                dispenseGrapeSoda();
                pay.clearPayList();
                Console.WriteLine("Your change for this transaction is {0}", pay.payListValue);
            } 
            else if (grape.sodaCost < pay.payListValue)
            {
                
                pay.payListValue -= grape.sodaCost;
                pay.payListValue += pay.changeValue;
                totalSodaMachineChange += grape.sodaCost;
                dispenseGrapeSoda();
                Console.WriteLine("\nYou paid too much for the {0} soda, your change is ${1:C}\n", grape, pay.payListValue);
                
                pay.clearPayList();
            }
            else
            {
                Console.WriteLine("\nThat is not enought for the {0} soda, you still have ${1:C}\n", grape, pay.payListValue);
            }
           
            return grape;
        }

        public Soda buyOrangeSoda(List<Coin> payList, double payListValue)
        {
            if (orange.sodaCost == payListValue)
            {
                totalSodaMachineChange += payListValue;
                foreach (Coin coin in payList)
                {
                    Console.WriteLine(coin);
                }
                dispenseOrangeSoda();
                pay.clearPayList();
                Console.WriteLine("Your change for this transaction is {0:C}", pay.payListValue);
            }
            else if (orange.sodaCost < payListValue)
            {
                pay.payListValue -= orange.sodaCost;
                totalSodaMachineChange += orange.sodaCost;
                dispenseOrangeSoda();
                Console.WriteLine("\nYou paid too much for the {0} soda, your change is ${1:C}\n", orange, pay.payListValue);
            }
            else
            {
                Console.WriteLine("\nThat is not enought for the {0} soda, you still have ${1:C}\n", orange, pay.payListValue);
            }
            return orange;
        }

        public Soda buyMeatSoda(List<Coin> payList, double payListValue)
        {
            if (meat.sodaCost == payListValue)
            {
                totalSodaMachineChange += payListValue;
                foreach (Coin coin in payList)
                {
                    Console.WriteLine(coin);
                }
                dispenseMeatSoda();
                pay.clearPayList();
                Console.WriteLine("Your change for this transaction is {0:C}", pay.payListValue);
            }
            else if (meat.sodaCost < payListValue)
            {
                payListValue -= meat.sodaCost;
                totalSodaMachineChange += meat.sodaCost;
                dispenseMeatSoda();
                Console.WriteLine("\nYou paid too much for the {0} soda, your change is ${1:C}\n", meat, pay.payListValue);
            }
            else
            {
                Console.WriteLine("\nThat is not enought for the {0} soda, you still have ${1:C}\n", meat, pay.payListValue);
            }
            return meat;
        }

        public void dispenseGrapeSoda()
        {
            sodas.Remove(grape);
            grapeSodasLeft -= grape.soda;
            totalSodasInMachine = sodas.Count;
            Console.WriteLine("You have purchased a {0} ", grape);
        }

        public void dispenseOrangeSoda()
        {
            sodas.Remove(orange);
            orangeSodasLeft -= orange.soda;
            totalSodasInMachine = sodas.Count;
            Console.WriteLine("You have purchased a {0} soda", orange);
            
        }

        public void dispenseMeatSoda()
        {
            sodas.Remove(meat);
            meatSodasLeft -= meat.soda;
            totalSodasInMachine = sodas.Count;
            Console.WriteLine("You have purchased a {0} soda", meat);
        }

     
        public override string ToString()
        {
            return string.Format("\nSoda Machine Change Total: {0:C} \n Sodas left in Machine: {1} \n Grape Sodas Left: {2} \n Orange Sodas Left: {3} \n Meat Sodas Left: {4} \n\n", totalSodaMachineChange, totalSodasInMachine, grapeSodasLeft, orangeSodasLeft, meatSodasLeft);
        }

        //public override string ToString()
        //{
        //    return string.Format("Soda Machine Change Total: ${0:C} \n Sodas left in Machine: {1}", totalSodaMachineChange, totalSodasInMachine);
        //}
    }
}
