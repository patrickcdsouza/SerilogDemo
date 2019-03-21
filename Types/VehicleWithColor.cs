namespace SerilogDemo.Types
{
    /// <summary>
    /// Holds vehicle information.
    /// </summary>
    public class VehicleWithColor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleWithColor"/> class.
        /// </summary>
        /// <param name="model"> The model. </param>
        /// <param name="year"> The year. </param>
        public VehicleWithColor(string model, int year)
        {
            this.Model = model;
            this.Year = year;
            this.Color = new VehicleColor(11, 22, 33);
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
        /// Gets or sets the year.
        /// </summary>
        public VehicleColor Color { get; set; }
    }
}
