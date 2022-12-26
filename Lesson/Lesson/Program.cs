using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.Name = "Hikmet";
            human1.Surname = "Abbasov";
            human1.Age = 20;

            Console.WriteLine(human1.GetInfo());


            Student student1 = new Student();
            student1.Name = "Tofiq";
            student1.Surname = "Qulamov";
            student1.Age = 22;
            student1.GroupNo = "P232";

            Console.WriteLine(student1.GetInfo());

            ProgrammingStudent ps1 = new ProgrammingStudent();

            Console.WriteLine(ps1.GetInfo());



            Driver driver1 = new Driver { Fullname = "Abbas", Age = 55, Experience = 30 };
            Car car1 = new Car(driver1);

            //car1.Driver = new Driver { Fullname = "Abbas", Age = 55, Experience = 30 };

            Console.WriteLine(car1.Driver.Fullname);

            Store store = new Store("Hikmentin butkasi")
            {
                Products = new Product[3] { new Product { Name = "Milla Ayran 1L", Price = 1.4 }, new Product { Name = "Milla Sud 1L", Price = 2.4 }, new Product { Name = "Milla Qatiq", Price = 1 } }
            };


            Console.WriteLine(store.Name);
            Console.WriteLine(store.Products.Length+" - ortlama qiymet: "+store.AvgPrice.ToString("0.00"));

        }


    }
}
