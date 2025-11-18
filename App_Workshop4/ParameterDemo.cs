using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop4
{
    internal class ParameterDemo
    {
        public void Increase(ref int number)
        {
            number += 10;
        }

        public void GetFullName(out string fullname)
        {
            fullname = "Shar";
        }

        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
                sum += n;
            return sum;
        }
    }
}
