namespace SerilogDemo.Examples
{
    using System;
    using System.Windows;

    using Serilog;

    /// <summary>
    /// Interaction logic for demonstrating how <c>Serilog</c> logs information to a rolling text file.
    /// </summary>
    public partial class SL03VehicleInfoToRollingTextFile : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SL03VehicleInfoToRollingTextFile"/> class.
        /// </summary>
        public SL03VehicleInfoToRollingTextFile()
        {
            this.InitializeComponent();

            ILogger logger = new LoggerConfiguration().WriteTo.RollingFile("SL03Rolling.txt", retainedFileCountLimit: 2).CreateLogger();
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
