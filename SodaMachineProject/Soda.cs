using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public abstract class Soda : IEnumerable
    {
        public List<Soda> sodas;
        public string sodaType;
        public double sodaCost;
        public int soda;

        public Soda()
        {
            soda = 1;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Soda soda in sodas)
            {
                yield return soda;
            }
        }
    }
}
