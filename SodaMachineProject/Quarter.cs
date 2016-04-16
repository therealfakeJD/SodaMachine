using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Quarter : Coin
    {
        public List<Coin> coins;
        public string coinType;
      
        public new double value { get; set; }

        public Quarter()
        {
            coinType = "Quarter";
            value = .25;
            
        }

      
        public override string ToString()
        {
            return string.Format("{0} {1}", coinType, value);
        }
    }
}
