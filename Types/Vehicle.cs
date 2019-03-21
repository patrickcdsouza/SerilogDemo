namespace SerilogDemo.Types
{
    /// <summary>
    /// Holds vehicle information.
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class.
        /// </summary>
        /// <param name="model"> The model. </param>
        /// <param name="year"> The year. </param>
        public Vehicle(string model, int year)
        {
            this.Model = model;
            this.Year = year;
        }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        public int Year { get; set; }
    }
}
