using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassLab
{
    internal class OrArray : Arrays
    {
        private double[] arr;

        public override double[] Arr
        {
            get => arr; set
            {
                if (value is double[])
                {
                    arr = value;
                }
            }
        }

        public OrArray(double[] arr)
        {
            this.arr = arr;
        }

        public override void ElemByElem()
        {
            for (int item_index = 0; item_index < arr.Length; item_index++)
            {
                arr[item_index] = Math.Log(arr[item_index]);
            }
        }

        public override double[] Sum(double[] plenty)
        {
            return arr.Union(plenty).ToArray();
        }
    }
}
