using System.Collections;
using System.Collections.Generic;

namespace SodaMachineProject
{
    public abstract class Coin : IEnumerable 
    {
        public List<Coin> coins;
        public string coinType;
        public double value;
        public int count;
        public Coin()
        {
            count = 1;
        }
      
       
        

        public IEnumerator GetEnumerator()
        {
            foreach (Coin coin in coins)
            {
                yield return coin;
            }
        }

       

    }
}