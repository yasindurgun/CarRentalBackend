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
            //byModelYear(carManager);

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId+"\t"+car.ColorName + "\t" +car.BrandName + "\t" +car.ModelYear);
            }


            Car car1 = new Car();
            car1.BrandId = 3;
            car1.ColorId = 1;
            car1.ModelYear = 2017;
            car1.DailyPrice = 100000;
            car1.Description = "just a car";

            //carManager.Add(car1);

            //getAllMethod(carManager);
            Console.ReadKey();
        }

        private static void getAllMethod(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void byModelYear(CarManager carManager)
        {
            foreach (var car in carManager.GetAllByModelYear(2017))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
