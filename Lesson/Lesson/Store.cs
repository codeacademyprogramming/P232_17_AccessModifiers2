using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Store
    {
        public Store(string name)
        {
            Name = name;
        }
        public readonly string Name;
        public Product[] Products;

        public double AvgPrice
        {
            get => _avgPrice();
        }
        private double _avgPrice()
        {
            double sum = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                sum += Products[i].Price;
            }

            return sum / Products.Length;
        }


    }
}
