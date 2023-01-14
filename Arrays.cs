using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassLab
{
    internal abstract class Arrays
    {
        public abstract double[] Arr { get; set; }
        public abstract double[] Sum(double[] plenty);
        public abstract void ElemByElem();
    }
}
