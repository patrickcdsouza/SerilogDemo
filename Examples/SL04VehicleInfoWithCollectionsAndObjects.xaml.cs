namespace SerilogDemo.Examples
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Windows;

    using Serilog;

    using SerilogDemo.Types;

    /// <summary>
    /// Interaction logic for demonstrating how <c>Serilog</c> logs information containing collections and objects.
    /// </summary>
    public partial class SL04VehicleInfoWithCollectionsAndObjects : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SL04VehicleInfoWithCollectionsAndObjects"/> class.
        /// </summary>
        public SL04VehicleInfoWithCollectionsAndObjects()
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
            VehicleWithToStringOveride vehicle = new VehicleWithToStringOveride(this.VehicleModel.Text, Convert.ToInt32(this.VehicleYear.Text));
            Log.Information("Added vehicle {Vehicle}", vehicle);

            IEnumerable preferredColors = new List<string> { "Red", "Blue", "Black" };
            Log.Information("My preferred vehicle colors: {VehicleColors}", preferredColors);

            Dictionary<string, int> availableCarsPerColor = new Dictionary<string, int> { { "Red", 1 }, { "Blue", 2 }, { "Black", 0 } };
            Log.Information("Available Cars Per Color: {AvailableCarsPerColor}", availableCarsPerColor);
        }
    }
}
