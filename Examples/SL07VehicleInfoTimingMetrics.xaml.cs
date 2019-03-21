namespace SerilogDemo.Examples
{
    using System;
    using System.Threading;
    using System.Windows;

    using Serilog;

    /// <summary>
    /// Interaction logic for demonstrating how <c>Serilog</c> logs information via timing metrics.
    /// </summary>
    public partial class SL07VehicleInfoTimingMetrics : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SL07VehicleInfoTimingMetrics"/> class.
        /// </summary>
        public SL07VehicleInfoTimingMetrics()
        {
            this.InitializeComponent();

            ILogger logger = new LoggerConfiguration().WriteTo.ColoredConsole().CreateLogger();
            Log.Logger = logger;
        }

        /// <summary> The add button clicked event. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e"> The e. </param>
        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            using (Log.Logger.BeginTimedOperation("Time a thread sleep for 2 seconds.", warnIfExceeds: TimeSpan.FromSeconds(10)))
            {
                Thread.Sleep(2000);
            }
        }
    }
}
