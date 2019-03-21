namespace SerilogDemo.Examples
{
    using System;
    using System.Windows;

    using Serilog;
    using Serilog.Exceptions;
    using Serilog.Formatting.Compact;

    using SerilogDemo.Types;

    /// <summary>
    /// Interaction logic for demonstrating how <c>Serilog</c> logs information using Enrichers.
    /// </summary>
    public partial class SL08VehicleInfoUsingEnrichers : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SL08VehicleInfoUsingEnrichers"/> class.
        /// </summary>
        public SL08VehicleInfoUsingEnrichers()
        {
            this.InitializeComponent();

            ILogger logger = new LoggerConfiguration().Enrich.WithExceptionDetails()
                                                        .Enrich.WithThreadId()
                                                        .Enrich.WithAssemblyName()
                                                        .Enrich.WithAssemblyVersion()
                                                        .Enrich.WithProperty("ApplicationVersion", "1.2.3.4")
                                                        .Enrich.WithMemoryUsage()
                                                        .WriteTo
                                                        .File(new CompactJsonFormatter(), "SL08.clef")
                                                        .CreateLogger();
            Log.Logger = logger;
        }

        /// <summary> The add button clicked event. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e"> The e. </param>
        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Vehicle vehicle = new Vehicle(this.VehicleModel.Text, Convert.ToInt32(this.VehicleYear.Text));
                Log.Information("Added vehicle {@Vehicle}", vehicle);
            }
            catch (Exception exception)
            {
                Log.Error(exception, "Error adding vehicle.");
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
