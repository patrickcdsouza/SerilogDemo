namespace SerilogDemo.Examples
{
    using System;
    using System.Windows;

    using Serilog;

    using SerilogDemo.Types;

    /// <summary>
    /// Interaction logic for demonstrating how <c>Serilog</c> logs information to JSON log files.
    /// </summary>
    public partial class SL05VehicleInfoWithDestructuredObjects : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SL05VehicleInfoWithDestructuredObjects"/> class.
        /// </summary>
        public SL05VehicleInfoWithDestructuredObjects()
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
            Vehicle vehicle = new Vehicle(this.VehicleModel.Text, Convert.ToInt32(this.VehicleYear.Text));
            Log.Information("Added vehicle {@Vehicle}", vehicle);

            VehicleWithColor vehicleWithColor = new VehicleWithColor(this.VehicleModel.Text, Convert.ToInt32(this.VehicleYear.Text));
            Log.Information("Added vehicle {@VehicleWithColor}", vehicleWithColor);
        }
    }
}
