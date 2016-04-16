using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
   
    class GrapeSoda : Soda
    {
        public string sodaType;
        public new double sodaCost;

        public GrapeSoda()
        {
            sodaType = "Grape Soda";
            sodaCost = .60;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", sodaType, sodaCost);
        }
    }
}
