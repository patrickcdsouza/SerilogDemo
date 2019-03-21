namespace SerilogDemo.Types
{
    /// <summary>
    /// Holds vehicle information.
    /// </summary>
    public class VehicleWithToStringOveride
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleWithToStringOveride"/> class.
        /// </summary>
        /// <param name="model"> The model. </param>
        /// <param name="year"> The year. </param>
        public VehicleWithToStringOveride(string model, int year)
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

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns> The <see cref="string"/>. </returns>
        public override string ToString()
        {
            return $"Model: \"{this.Model}\" Year:{this.Year}";
        }
    }
}
