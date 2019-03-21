namespace SerilogDemo.Examples
{
    using System;
    using System.Windows;

    using Serilog;
    using Serilog.Formatting.Compact;

    using SerilogDemo.Types;

    /// <summary>
    /// Interaction logic for demonstrating how <c>Serilog</c> logs information containing collections and objects.
    /// </summary>
    public partial class SL06VehicleInfoToJsonLogFiles : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SL06VehicleInfoToJsonLogFiles"/> class.
        /// </summary>
        public SL06VehicleInfoToJsonLogFiles()
        {
            this.InitializeComponent();

            ILogger logger = new LoggerConfiguration().WriteTo.File(new CompactJsonFormatter(), "SL06.clef").CreateLogger();
            Log.Logger = logger;
        }

        /// <summary> The add button clicked event. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e"> The e. </param>
        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            string[] models = { "Venom F5", "Tuatara", "Agera RS", "Veyron Super Sport", "Chiron", "Veneno", "CCXR Trevita", "V8 Vantage", "488 GTB Pista", "Aventador Roadster" };
            foreach (string model in models)
            {
                for (int i = 2000; i < 2020; i++)
                {
                    Vehicle vehicle = new Vehicle(model, i);
                    Log.Information("Added vehicle {@Vehicle}", vehicle);
                    Log.Information(
                        "Added vehicle color {@VehicleColor}",
                        new VehicleColor(
                            random.Next(0, 255),
                            random.Next(0, 255),
                            random.Next(0, 255)));
                }
            }
        }





        /*
        https://github.com/datalust/clef-tool
        clef -i SL06.clef
        clef -i SL06.clef --filter="VehicleColor.Red = 124"
        clef -i SL06.clef --filter="Vehicle.Model like 'Ve%'"
        clef -i SL06.clef --filter="Vehicle.Year=2012 and Vehicle.Model='Venom F5'"
        */

    }
}
