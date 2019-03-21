namespace SerilogDemo.Types
{
    /// <summary>
    /// Holds vehicle information.
    /// </summary>
    public class VehicleColor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleColor"/> class.
        /// </summary>
        /// <param name="red"> The red color component value. </param>
        /// <param name="green"> The green color component value. </param>
        /// <param name="blue"> The blue color component value. </param>
        public VehicleColor(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        /// <summary>
        /// Gets or sets the red color component value.
        /// </summary>
        public int Red { get; set; }

        /// <summary>
        /// Gets or sets the green color component value.
        /// </summary>
        public int Green { get; set; }

        /// <summary>
        /// Gets or sets the blue color component value.
        /// </summary>
        public int Blue { get; set; }
    }
}
