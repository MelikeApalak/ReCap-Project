using Business.Concrete;
using DataAccess.Abstract;
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
            //CarAdded();
            

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.RentDate);
            }
            Rental rental = new Rental();
            rental.CarId = 2000;
            rental.CustomerId = 5;
            rental.RentDate = new DateTime(2021, 2, 21);
            var result2 = rentalManager.Add(rental);
            Console.WriteLine(result2.Message);



        }

        private static void CarAdded()
        {
            Car car = new Car
            {

                BrandId = 1,
                ColorId = 1,
                DailyPrice = 30000,
                Description = "ford",

                ModelYear = 2010,
            };

            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.Add(car).Message);
        }
    }
}
