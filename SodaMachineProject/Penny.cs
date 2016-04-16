using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    

    public class Penny : Coin
    {
        public List<Coin> coins;
        public string coinType;
        public new double value { get; set; }

        public Penny()
        {
            coinType = "Penny";
            value = .01;
        }

     

        public override string ToString()
        {
            return string.Format("{0} {1}", coinType, value);
        }
    }
}
