namespace SerilogDemo.Examples
{
    using System;
    using System.Windows;

    using Serilog;

    /// <summary>
    /// Interaction logic for demonstrating how <c>Serilog</c> logs information to the Console.
    /// </summary>
    public partial class SL01VehicleInfoToConsole : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SL01VehicleInfoToConsole"/> class.
        /// </summary>
        public SL01VehicleInfoToConsole()
        {
            this.InitializeComponent();

            ILogger logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Log.Logger = logger;
        }

        /// <summary> The add button clicked event. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e"> The e. </param>
        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            string model = this.VehicleModel.Text;
            string year = this.VehicleYear.Text;
            Log.Information("Added vehicle with Model {VehicleModel}, Year {VehicleYear} on {AddedDate}", model, year, DateTime.Now);
        }
    }
}
