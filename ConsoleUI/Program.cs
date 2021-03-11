using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllByModelYear(2017))
            {
                Console.WriteLine(car.Description);
            }
            Car car1 = new Car();
            car1.BrandId = 3;
            car1.ColorId = 1;
            car1.ModelYear = 2020;
            car1.DailyPrice = 100000;
            car1.Description = "new car 1";

            //carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.ReadKey();
        }
    }
}
