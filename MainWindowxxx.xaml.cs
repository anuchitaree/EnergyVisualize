using EnergyVisualize.Helpers;
using EnergyVisualize.Models;
using ScottPlot.Plottables;
using System.Net.Http;
using System.Text.Json;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace EnergyVisualize
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //public UsageEnergyPage usageEnergyPage;
        //public PowerPeakPage powerPeakPage;

        //public object CurrentView { get; set; }
        //public ICommand ShowUsageEnergyCommand { get; }
        //public ICommand ShowPowerPeakCommand { get; }
        public MainWindow()
        {
            InitializeComponent();

            //ShowUsageEnergyCommand = new RelayCommand(_ => CurrentView = new UsageEnergyView());
            //ShowPowerPeakCommand = new RelayCommand(_ => CurrentView = new PowerPeakView());
            //usageEnergyPage = new UsageEnergyPage();
            //powerPeakPage = new PowerPeakPage();
        }

        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
          //  HttpClient client = new HttpClient();
          //  string url = "http://localhost:5228/api/v1/data-visualize/one-day";
          //  HttpResponseMessage response = await client.GetAsync(url);
          //  response.EnsureSuccessStatusCode();
          //  var options = new JsonSerializerOptions
          //  {
          //      PropertyNameCaseInsensitive = true
          //  };
          //  List<EnergyMinute> posts = new List<EnergyMinute>();

          //  if (response.IsSuccessStatusCode)
          //  {
          //      string json = await response.Content.ReadAsStringAsync();

          //      posts = JsonSerializer.Deserialize<List<EnergyMinute>>(json, options) ?? new List<EnergyMinute>();

          //  }


          //  // แปลงข้อมูลเป็น ScottPlot format
          //  double[] xs = posts
          //      .Select(x => x.Minute.ToOADate())
          //      .ToArray();

          //  double[] ys = posts
          //      .Select(x => Convert.ToDouble(x.MaxPower))
          //      .ToArray();

          //  // เพิ่มเส้นกราฟ
          //var scatter1 = EnergyPlot.Plot.Add.Scatter(xs, ys);
          //  scatter1.Color = ScottPlot.Color.FromHex("#108000"); 

          //  // ตั้งค่าแกนเวลา
          //  EnergyPlot.Plot.Axes.DateTimeTicksBottom();

          //  // label
          //  EnergyPlot.Plot.Title("Energy Usage");
          //  EnergyPlot.Plot.YLabel("Energy (kWh)");
          //  EnergyPlot.Plot.XLabel("Time");

          //  // refresh
          //  EnergyPlot.Refresh();







          //   url = "http://localhost:5228/api/v1/data-visualize/one-day-hourly";
          //   response = await client.GetAsync(url);
          //  response.EnsureSuccessStatusCode();
          //   options = new JsonSerializerOptions
          //  {
          //      PropertyNameCaseInsensitive = true
          //  };
          //  List<EnergyHour> hourdata = new List<EnergyHour>();

          //  if (response.IsSuccessStatusCode)
          //  {
          //      string json = await response.Content.ReadAsStringAsync();

          //      hourdata = JsonSerializer.Deserialize<List<EnergyHour>>(json, options) ?? new List<EnergyHour>();

          //  }
          //  // แปลงข้อมูลเป็น ScottPlot format
          //  double[] xs1 = hourdata
          //      .Select(x => x.Hour.ToOADate())
          //      .ToArray();

          //  double[] ys1 = hourdata
          //      .Select(x => Convert.ToDouble(x.MaxPower))
          //      .ToArray();

          //  // เพิ่มเส้นกราฟ
          //  var scatter2 = EnergyPlot2.Plot.Add.Scatter(xs1, ys1);
          //  scatter2.Color = ScottPlot.Color.FromHex("#FF0000"); // Example: set to red

          //  // ตั้งค่าแกนเวลา
          //  EnergyPlot2.Plot.Axes.DateTimeTicksBottom();

          //  // label
          //  EnergyPlot2.Plot.Title("Energy Usage");
          //  EnergyPlot2.Plot.YLabel("Energy (kWh)");
          //  EnergyPlot2.Plot.XLabel("Hour");

          //  // refresh
          //  EnergyPlot2.Refresh();

        //}


    }
}