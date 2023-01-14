using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassLab
{
    internal class AndArray : Arrays
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

        public AndArray(double[] arr)
        {
            this.arr = arr;
        }

        public override void ElemByElem()
        {
            for (int item_index = 0; item_index < arr.Length; item_index++)
            {
                arr[item_index] = Math.Sqrt(Math.Abs(arr[item_index]));
            }
        }

        public override double[] Sum(double[] plenty)
        {
            List<double> result = new List<double>();
            foreach (var item in plenty)
            {
                if (Array.IndexOf(arr, item) >= 0)
                {
                    result.Add(item);
                }
                
            }

            return result.ToArray();
        }
    }
}
