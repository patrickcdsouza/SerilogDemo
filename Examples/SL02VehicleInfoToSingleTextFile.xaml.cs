namespace SerilogDemo.Examples
{
    using System;
    using System.Windows;

    using Serilog;

    /// <summary>
    /// Interaction logic for demonstrating how <c>Serilog</c> logs information to a single text file.
    /// </summary>
    public partial class SL02VehicleInfoToSingleTextFile : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SL02VehicleInfoToSingleTextFile"/> class.
        /// </summary>
        public SL02VehicleInfoToSingleTextFile()
        {
            this.InitializeComponent();

            ILogger logger = new LoggerConfiguration().WriteTo.File("SL02.txt").CreateLogger();
            Log.Logger = logger;
        }

        /// <summary> The add button clicked event. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e"> The e. </param>
        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            string model = this.VehicleModel.Text;
            int year = Convert.ToInt32(this.VehicleYear.Text);
            Log.Information("Added vehicle with Model {VehicleModel}, Year {VehicleYear} on {AddedDate}", model, year, DateTime.Now);
        }
    }
}
