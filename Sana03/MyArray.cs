using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana03
{
    public class MyArray
    {
        private double[] array;
        public MyArray(double[] array) { 
            this.array = array;
        }
        public double SumOfNegativeNumbers()
        {
            double sum_neg = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    sum_neg += array[i];
            }
            return sum_neg;
        }
        public double MinElementOfArray() {
            double min = array[0];
            for (int i = 1; i < array.Length; i++) {
                if (array[i] < min) min = array[i];
            }
            return min;
        }
        public int MaxIndextOfArray() {
            int max = 0;
            for (int i = 1; i < array.Length; i++) {
                if (array[i] >  array[max]) max = i;
            }
            return max;
        }
        public double MaxModuleElementOfArray()
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > Math.Abs(max))  max = array[i];
            }
            return max;
        }
        public double SumIndexOfPositiveElements()
        {
            double sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) sum += i;
            }
            return sum;
        }
        public int IntegerNumnersInArray() {
            int amount = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == (int)array[i]) amount++;
            }
            
            return amount;
        }


    }
}
