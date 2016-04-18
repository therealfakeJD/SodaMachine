using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Payment
    {
        public List<Coin> payList;
        public List<Coin> changeList;
        public Quarter payQuarter = new Quarter();
        public Dime payDime = new Dime();
        public Nickel payNickel = new Nickel();
        public Penny payPenny = new Penny();
        public double payListValue;
        public double changeValue;
      
        public Payment()
        {

            payList = new List<Coin>();
            payListValue = 0;
            changeList = new List<Coin>();
            changeValue = 0;
        }

        public List<Coin> payForDrink()
        {
            useChange();
            Console.WriteLine("How many quarters will you pay?");
            payQuarter.count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < payQuarter.count; i++)
            {
                payList.Add(payQuarter);
                payListValue += payQuarter.value;
            }

            Console.WriteLine("How many dimes will you pay?");
            payDime.count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < payDime.count; i++)
            {
                payList.Add(payDime);
                payListValue += payDime.value;
            }

            Console.WriteLine("How many nickels will you pay?");
            payNickel.count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < payNickel.count; i++)
            {
                payList.Add(payNickel);
                payListValue += payNickel.value;
            }

            Console.WriteLine("How many pennies will you pay?");
            payPenny.count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < payPenny.count; i++)
            {
                payList.Add(payPenny);
                payListValue += payPenny.value;
            }
            Console.WriteLine("You have chosen to put in ${0}", payListValue);
            return payList;
        }

        public void useChange()
        {

            Console.WriteLine("Change value equals {0}", changeValue);
            int choice;
            Console.WriteLine("Would you like to use your change from the last transaction?");
            Console.WriteLine("Press 1 for yes or press 2 for no.");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                payList.AddRange(changeList);
            }
            else
            {
                Console.WriteLine("You have chosen not to use your change");

            }
        }
        public List<Coin> payListTracker()
        {
            foreach(Coin coin in payList)
            {
                Console.WriteLine(coin);
            }
            return payList;
        }
        public double printPayListValue()
        {
            Console.WriteLine(payListValue);
            return payListValue;
        }

        public List<Coin> clearPayList()
        {
            payList.Clear();
            //payList.RemoveAll(Coin => Coin == payQuarter);
            //payList.RemoveAll(Coin => Coin == payDime);
            //payList.RemoveAll(Coin => Coin == payNickel);
            //payList.RemoveAll(Coin => Coin == payPenny);
            payListValue = payList.Count;
            Console.WriteLine("The payList now has {0} elements", payList.Count);
            return payList;
        }

       
        public override string ToString()
            {
                return
                    string.Format(
                        "You have a paylist with {0} Quarters, {1} Dimes, {2} Nickels and {3} pennies for a total of ${4}",
                        payQuarter.count, payDime.count, payNickel.count, payPenny.count, payListValue);
            }
    }
}
