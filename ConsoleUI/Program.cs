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
            //CarManager carManager = InMemoryCarManager();

            //AddCarWithCarManager();

            //BrandOperations();

            //CarManager carManager = new CarManager(new EfCarDal());

            //GetCarDetailsOperation();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental()
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = DateTime.Now.AddDays(-10),
                ReturnDate = DateTime.Now.AddDays(-5),
            };
            Console.WriteLine("deneme1");
            rentalManager.AddRental(rental);
            Console.WriteLine("deneme2");
            Console.ReadKey();
        }

        //private static void GetCarDetailsOperation()
        //{
        //    foreach (var item in carManager.GetCarDetails())
        //    {
        //        Console.WriteLine($"Car Name: {item.BrandName}");
        //        Console.WriteLine($"Description: {item.Description}");
        //        Console.WriteLine($"Daily Price: {item.DailyPrice}");
        //        Console.WriteLine($"Color: {item.ColorName}");
        //        Console.WriteLine();
        //        Console.WriteLine("**********\n");
        //    }
        //}

        //private static void BrandOperations()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    var brand = brandManager.GetById(55);

        //    Console.WriteLine(brand.BrandName);
        //}

        //private static void AddCarWithCarManager()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    Car car = new Car
        //    {
        //        BrandId = 2,
        //        ColorId = 3,
        //        Description = "White BMW",
        //        DailyPrice = 0,
        //        ModelYear = "2021"
        //    };

        //    carManager.AddCar(car);
        //}

        //private static CarManager InMemoryCarManager()
        //{
        //    CarManager carManager = new CarManager(new InMemoryCarDal());
        //    foreach (var item in carManager.GetAll())
        //    {
        //        Console.WriteLine($"Car Description: {item.Description}");
        //    }

        //    return carManager;
        //}
    }
}
