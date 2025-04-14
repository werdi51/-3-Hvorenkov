using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace практтика_3_задание_4
{
    public class Calculator
    {
         public ArrayList collection = new ArrayList();

        public void AddItem(object item)
        {
            collection.Add(item);
        }

        public double SumAllNumbers()
        {
            double sum = 0;
            foreach (var item in collection)
            {
                if (double.TryParse(item.ToString(), out double number))
                    sum += number;
            }
            return sum;
        }


        public double FindMaxNumber()
        {
            double max = double.MinValue;
            foreach (var item in collection)
            {
                if (double.TryParse(item.ToString(), out double number))
                    max = Math.Max(max, number);
            }
            return max;
        }


        public ArrayList GetAllItems()
        {
            return collection;
        }
    }
}
