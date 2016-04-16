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
        
        public List<Coin> coins;
        public List<Soda> sodas;
        public List<Coin> payList;
        public double totalSodaMachineChange;
        public int totalSodasInMachine;
        public int grapeSodasLeft;
        public int orangeSodasLeft;
        public int meatSodasLeft;
        public double changeGiven;
      
        public SodaMachine()
        {
            
            totalSodaMachineChange = 0;
            totalSodasInMachine = 0;
            coins = new List<Coin>();
            sodas = new List<Soda>();
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
  
        public Soda buyGrapeSoda(double payListValue)
        {
            if (grape.sodaCost == payListValue)
            {
                totalSodaMachineChange += payListValue;
                dispenseGrapeSoda();
            } 
            else if (grape.sodaCost < payListValue)
            {
                payListValue -= grape.sodaCost;
                totalSodaMachineChange += grape.sodaCost;
                dispenseGrapeSoda();
                Console.WriteLine("\nYou paid too much for the {0} soda, your change is ${1:C}\n", grape, payListValue);
            }
            else
            {
                Console.WriteLine("\nThat is not enought for the {0} soda, you still have ${1:C}\n", grape, payListValue);
            }
            
            return grape;
        }

        public Soda buyOrangeSoda(double payListValue)
        {
            if (orange.sodaCost == payListValue)
            {
                totalSodaMachineChange += payListValue;
                dispenseOrangeSoda();
            }
            else if (orange.sodaCost < payListValue)
            {
                payListValue -= orange.sodaCost;
                totalSodaMachineChange += orange.sodaCost;
                dispenseOrangeSoda();
                Console.WriteLine("\nYou paid too much for the {0} soda, your change is ${1:C}\n", orange, payListValue);
            }
            else
            {
                Console.WriteLine("\nThat is not enought for the {0} soda, you still have ${1:C}\n", orange, payListValue);
            }
            return orange;
        }

        public Soda buyMeatSoda(double payListValue)
        {
            if (meat.sodaCost == payListValue)
            {
                totalSodaMachineChange += payListValue;
                
                dispenseMeatSoda();
            }
            else if (meat.sodaCost < payListValue)
            {
                payListValue -= meat.sodaCost;
                totalSodaMachineChange += meat.sodaCost;
                dispenseMeatSoda();
                Console.WriteLine("\nYou paid too much for the {0} soda, your change is ${1:C}\n", meat, payListValue);
            }
            else
            {
                Console.WriteLine("\nThat is not enought for the {0} soda, you still have ${1:C}\n", meat, payListValue);
            }
            return meat;
        }

        public void dispenseGrapeSoda()
        {
            sodas.Remove(grape);
            grapeSodasLeft -= grape.soda;
            totalSodasInMachine = sodas.Count;
            Console.WriteLine("You have purchased a {0} soda", grape);
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
