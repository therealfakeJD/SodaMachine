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
        public Quarter payQuarter = new Quarter();
        public Dime payDime = new Dime();
        public Nickel payNickel = new Nickel();
        public Penny payPenny = new Penny();
        public double payListValue;
      
        public Payment()
        {
            
            payList = new List<Coin>();
            payListValue = 0;
        }

        public double payForDrink()
        {

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
            return payListValue;
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
