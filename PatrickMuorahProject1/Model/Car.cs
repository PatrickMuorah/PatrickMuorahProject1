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
    public class Car
    {
        /// <summary>
        /// Gets or sets the make of a car.
        /// </summary>
        /// <value>
        /// The make.
        /// </value>
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the model of a car.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the MPG of a car.
        /// </summary>
        /// <value>
        /// The MPG.
        /// </value>
        public decimal Mpg { get; set; }

        /// <summary>
        /// Gets or sets the price of a car.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <param name="mpg">The MPG.</param>
        /// <param name="price">The price.</param>
        /// <exception cref="System.ArgumentException">
        /// Make cannot be null, empty, or whitespace.
        /// or
        /// Model cannot be null, empty, or whitespace.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// mpg - MPG must be a positive value.
        /// or
        /// price - Price must be a positive value.
        /// </exception>
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

        /// <summary>
        /// Converts to string the details of a Car object.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{Make} {Model} {Price:C} {Mpg:0.0}mpg";
        }


    }
}
