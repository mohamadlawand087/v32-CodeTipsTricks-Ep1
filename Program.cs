using System;

namespace ctte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Mickey!");

            var name = "Mohamad";
            var name2 = "John";
            var name3 = "Mickey";

            var outputString = string.Format("Hello {0}, {1} and {2}!", name, name2, name3);
            Console.WriteLine(outputString);

            var outputStringV2 = $"Hello {name}, {name2.ToUpper()} and {name3.ToUpper()}!";
            Console.WriteLine(outputStringV2);

            var car = new Car("Jeep", "Grey", "V8", 2015, 29500.25);

            var carInfo = $"The car {car.brand}, "
                        + $"of color {car.color} "
                        + $"made in {car.year} "
                        + $"is worth ${car.price} "
                        + $"on {DateTime.Now:d} "
                        + $"this is an {(car.price <= 20000 ? "low": "high")} price "
                        + $" this is a brace {{  {DateTime.Now.Year} ";

            Console.WriteLine(carInfo);

            // Discard
            var (_, _, price, mileage, _, _) = GetCarInformation(car.brand, car.year, car.engine);

            Console.WriteLine($"Car info, Model {car.brand}, price {price}, mileage {mileage}");

            (string, double, int, int, int, int) GetCarInformation(string brand, int year, string engine)
            {
                if(brand == "Jeep")
                {
                    return (name, 0, 35000, 130000, 0,5);
                }
                return ("name", 0, 0, 0, 0,0);
            }
            
            var dateCheck = "06/06/2021 09:18:33.8";

            var checkResult = DateTime.TryParse(dateCheck, out _);
            if(checkResult)
                Console.WriteLine($"{dateCheck} valid date");
            else
                Console.WriteLine($"{dateCheck} Invalid date");

        }

        record Car (string brand, string color, string engine, int year, double price);
    }
}
