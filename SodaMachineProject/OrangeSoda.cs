using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class OrangeSoda : Soda
    {
        public string sodaType;
        public new double sodaCost;

        public OrangeSoda()
        {
            sodaType = "Orange Soda";
            sodaCost = .35;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", sodaType, sodaCost);
        }
    }
}
