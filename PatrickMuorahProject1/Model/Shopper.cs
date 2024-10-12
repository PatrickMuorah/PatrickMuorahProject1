using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrickMuorahProject1.Model
{
    /// <summary>
    /// Contains information about the shopper of a car
    /// </summary>
    internal class Shopper
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the money available.
        /// </summary>
        /// <value>
        /// The money available.
        /// </value>
        public decimal? MoneyAvailable { get; set; }

        /// <summary>
        /// Gets or sets the cars.
        /// </summary>
        /// <value>
        /// The cars.
        /// </value>
        private List<Car> Cars { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shopper"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="moneyAvailable">The money available.</param>
        /// <exception cref="System.ArgumentException">
        /// Name cannot be null or empty.
        /// or
        /// The Money available cannot be negative.
        /// </exception>
        public Shopper(string name, decimal moneyAvailable)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.");
            if (moneyAvailable < 0)
                throw new ArgumentException("The Money available cannot be negative.");

            Name = name;
            MoneyAvailable = moneyAvailable;
            Cars = new List<Car>();
        }

        /// <summary>
        /// Determines whether this instance can purchase the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>
        ///   <c>true</c> if this instance can purchase the specified car; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">Car cannot be null</exception>
        public bool CanPurchase(Car? car)
        {
            if (car == null)
                throw new ArgumentNullException("Car cannot be null");

            decimal totalCost = car.Price + (car.Price * 0.078m);
            return MoneyAvailable >= totalCost;
        }

        /// <summary>
        /// Purchases the car.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <exception cref="System.ArgumentNullException">Car cannot be null</exception>
        /// <exception cref="System.InvalidOperationException">Not enough money to purchase the car.</exception>
        public void PurchaseCar(Car? car)
        {
            if (car == null)
                throw new ArgumentNullException("Car cannot be null");

            if (!CanPurchase(car))
                throw new InvalidOperationException("Not enough money to purchase the car.");

            Cars.Add(car);
            MoneyAvailable -= (car.Price + (car.Price * 0.078m));
        }
    }
}
