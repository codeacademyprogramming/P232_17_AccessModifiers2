using AccessModifiers2.CarClasses;
using System;
using Date;

namespace AccessModifiers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classes.Car car1 = new Classes.Car();

            Lesson.Human human1 = new Lesson.Human();

            Product product = new Product();

            product.Price = 34;
        }
    }
}
