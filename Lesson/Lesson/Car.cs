using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Car
    {
        public Car()
        {
            this.Driver = new Driver();
        }

        public Car(Driver driver)
        {
            this.Driver = driver;
        }
        public string Brand;
        public string Model;
        public int Year;

        public Driver Driver;


    }
}
