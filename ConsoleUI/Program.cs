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
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine($"Car Description: {item.Description}");
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                BrandId = 2,
                ColorId = 3,
                Description = "White BMW",
                DailyPrice = 0,
                ModelYear = "2021"
            };

            carManager.AddCar(car);

            Console.ReadLine();
        }
    }
}
