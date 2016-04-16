using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class MeatSoda : Soda
    {
        public string sodaType;
        public new double sodaCost;

        public MeatSoda()
        {
            sodaType = "Meat Soda";
            sodaCost = .06;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", sodaType, sodaCost);
        }
    }
}
