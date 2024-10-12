using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrickMuorahProject1.Model
{
    /// <summary>
    /// Contains details aout the model of a specific car
    /// </summary>
    internal class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public decimal Mpg { get; set; }

        public decimal Price { get; set; }

        public Car(string make, string model, decimal mpg, decimal price)
        {

            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make cannot be null, empty, or whitespace.");

            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model cannot be null, empty, or whitespace.");

            if (mpg <= 0)
                throw new ArgumentOutOfRangeException(nameof(mpg), "MPG must be a positive value.");

            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be a positive value.");

            Make = make;
            Model = model;
            Mpg = mpg;
            Price = price;
        }


    }
}
