using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Dime : Coin
    {
        public List<Coin> coins;
        public string coinType;

        public double value { get; set; }

        public Dime()
        {
            coinType = "Dime";
            value = .10;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", coinType, value);
        }

    }
}
