using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrickMuorahProject1.Model
{
    /// <summary>
    /// Contains the Inventory of All the Cars 
    /// </summary>
    public class CarLot
    {
        public List<Car> Inventory;

        public const double TaxRate = 7.8;

        private List<Car> _inventory = new List<Car>();
        /// <summary>
        /// Initializes a new instance of the <see cref="CarLot"/> class.
        /// </summary>
        public CarLot()
        {
            Inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        /// <summary>
        /// Stocks the lot with default inventory.
        /// </summary>
        private void StockLotWithDefaultInventory()
        {
            Inventory.Add(new Car("Ford", "Focus ST", 28.3m, 26298.98m));
            Inventory.Add(new Car("Chevrolet", "Camaro ZL1", 19.0m, 65401.23m));
            Inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2m, 26780.00m));
            Inventory.Add(new Car("Lexus", "ES 350", 24.1m, 42101.10m));
        }

        /// <summary>
        /// Finds the cars by make.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <returns></returns>
        public List<Car>? FindCarsByMake(String make)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make cannot be null or empty.");

            List<Car> result = new List<Car>();

            foreach (var car in Inventory)
            {
                if (car.Make.Equals(make, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(car);
                }
            }
            if (result.Count > 0)
            {
                return result;
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Finds the car by make model.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public Car? FindCarByMakeModel(string make, string model)
        {

            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model cannot be null or empty.");

            foreach (var car in Inventory)
            {
                if (car.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &&
                    car.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
                {
                    return car;
                }
            }
            return null; 
        }

        /// <summary>
        /// Purchases the car.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public Car? PurchaseCar(string make, string model)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model cannot be null or empty.");

            foreach (var car in Inventory)
            {
                if (car.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &&
                    car.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
                {
                    Inventory.Remove(car);
                    return car;
                }
            }
            return null;
        }

        /// <summary>
        /// Adds the car.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <param name="mpg">The MPG.</param>
        /// <param name="price">The price.</param>
        /// <exception cref="System.ArgumentException">
        /// Make cannot be null or empty.
        /// or
        /// Model cannot be null or empty.
        /// </exception>
        public void AddCar(string make, string model, decimal mpg, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model cannot be null or empty.");

            if (mpg <= 0)
                throw new ArgumentOutOfRangeException("MPG must be greater than zero.");

            if (price < 0)
                throw new ArgumentOutOfRangeException("Price cannot be negative.");

            Car newCar = new Car(make, model, mpg, price);
            Inventory.Add(newCar);
        }

        /// <summary>
        /// Gets the total cost of purchase.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns></returns>
        public decimal GetTotalCostOfPurchase(Car car)
        {
            if (car == null)
                throw new ArgumentNullException("Car cannot be null.");
            return car.Price + (car.Price * 0.078m);
        }

        /// <summary>
        /// Finds the least expensive car.
        /// </summary>
        /// <returns></returns>
        public Car? FindLeastExpensiveCar()
        {
            if (Inventory.Count == 0)
            {
                return null;
            }

            Car theLeastExpensiveCar = Inventory[0];

            foreach (var car in Inventory)
            {
                if (car.Price < theLeastExpensiveCar.Price)
                {
                    theLeastExpensiveCar = car;
                }
            }
            return theLeastExpensiveCar;
        }

        /// <summary>
        /// Finds the most expensive car.
        /// </summary>
        /// <returns></returns>
        public Car? FindMostExpensiveCar()
        {
            if (Inventory.Count == 0)
            {
                return null;
            }

            Car theMostExpensiveCar = Inventory[0];

            foreach (var car in Inventory)
            {
                if (car.Price > theMostExpensiveCar.Price)
                {
                    theMostExpensiveCar = car;
                }
            }
            return theMostExpensiveCar;
        }

        /// <summary>
        /// Finds the best MPG car.
        /// </summary>
        /// <returns></returns>
        public Car? FindBestMPGCar()
        {
            if (Inventory.Count == 0)
            {
                return null;
            }

            Car theBestMpgCar = Inventory[0];

            foreach (var car in Inventory)
            {
                if (car.Mpg > theBestMpgCar.Mpg)
                {
                    theBestMpgCar = car;
                }
            }
            return theBestMpgCar;
        }

        /// <summary>
        /// Finds the worst MPG car.
        /// </summary>
        /// <returns></returns>
        public Car? FindWorstMPGCar()
        {
            if (Inventory.Count == 0)
            {
                return null;
            }

            Car theWorstMpgCar = Inventory[0];

            foreach (var car in Inventory)
            {
                if (car.Mpg < theWorstMpgCar.Mpg)
                {
                    theWorstMpgCar = car;
                }
            }
            return theWorstMpgCar;
        }



    }
}
