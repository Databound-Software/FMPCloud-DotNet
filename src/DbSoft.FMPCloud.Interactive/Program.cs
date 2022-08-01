using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Model;
using DBSoft.FMPCloud.Utilities;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DBSoft.FMPCloud.Interactive
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = new HostBuilder()
              .ConfigureAppConfiguration((hostingContext, config) =>
              {
                  config.AddJsonFile("appsettings.json", optional: true);
                  config.AddEnvironmentVariables();

                  if (args != null)
                  {
                      config.AddCommandLine(args);
                  }
              })
              .ConfigureServices((hostContext, services) =>
              {
                  services.AddOptions();
                  services.Configure<FMPCloudConfiguration>(hostContext.Configuration.GetSection("FMPCloudConfiguration"));
                  services.AddHttpClient();
                  services.AddFMPCloud();

                  services.AddHostedService<InteractiveConsole>();
              })
              .ConfigureLogging((hostingContext, logging) =>
              {
                  logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                  logging.AddConsole();
              });

            await builder.RunConsoleAsync();
        }
    }
    internal sealed class InteractiveConsole : IHostedService
    {
        private readonly IHostApplicationLifetime applicationLifetime;
        private readonly IFmpCloudClient client;

        public InteractiveConsole(IHostApplicationLifetime appLifetime, IFmpCloudClient client)
        {
            applicationLifetime = appLifetime;
            this.client = client;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            applicationLifetime.ApplicationStarted.Register(() =>
            {
                Task.Run(async () =>
                {
                    await MainMenu();
                });


            });

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private async Task MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Stock Time Series");
                Console.WriteLine("x. Exit");
                var result = Console.ReadKey();

                switch (result.Key)
                {
                    case ConsoleKey.D1:
                        await StockTimeSeriesMenu();
                        await MainMenu();
                        break;
                    case ConsoleKey.X:
                        return;
                    default:
                        break;

                }
            }
        }

        private async Task StockTimeSeriesMenu()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Real Time Quote");
                Console.WriteLine("2. Ticker Search");
                Console.WriteLine("3. Company Profile");
                Console.WriteLine("4. Key Executives");
                Console.WriteLine("5. Historical Stock Data");
                Console.WriteLine("6. Available Market and Tickers");
                Console.WriteLine("7. Major Index Constituents");
                Console.WriteLine("x. Exit");
                Console.WriteLine("Press ENTER to return to the main menu");
                var result = Console.ReadKey();

                switch (result.Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.Clear();
                            Console.Write("Enter symbol: ");
                            var symbol = Console.ReadLine();
                            var response = await client.StockTimeSeries.RealTimeQuote.GetAsync(new StockTimeSeries.Model.RealTimeQuoteRequest { Symbols = new string[] { $"{symbol}" } });
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            Console.Clear();
                            Console.Write("Enter search text: ");
                            var symbol = Console.ReadLine();
                            var response = await client.StockTimeSeries.TickerSearch.GetAsync(new StockTimeSeries.Model.TickerSearchRequest { Symbol = symbol });

                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D3:
                        {
                            Console.Clear();
                            Console.Write("Enter symbols (separated by comma): ");
                            var symbols = Console.ReadLine();
                            var response = await client.StockTimeSeries.CompanyProfile.GetAsync(new StockTimeSeries.Model.CompanyProfileRequest { Symbols = symbols.Split(',') });

                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D4:
                        {
                            Console.Clear();
                            Console.Write("Enter symbols (separated by comma): ");
                            var symbols = Console.ReadLine();
                            var response = await client.StockTimeSeries.KeyExecutives.GetAsync(new StockTimeSeries.Model.KeyExecutivesRequest { Symbols = symbols.Split(',') });

                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D5:
                        {
                            await HistoricalStockDataMenu();
                        }
                        break;
                    case ConsoleKey.D7:
                        {
                            await IndexConstituentsMenu();
                        }
                        break;
                    case ConsoleKey.X:
                        applicationLifetime.StopApplication();
                        break;
                    case ConsoleKey.Enter:
                        return;
                    default:
                        break;

                }
            }
        }

        private async Task IndexConstituentsMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. S&P 500 Companies");
                Console.WriteLine("2. S&P 500 Historical Companies");
                Console.WriteLine("3. Nasdaq 100 Companies");
                Console.WriteLine("4. Nasdaq 100 Historical Companies");
                Console.WriteLine("5. Dow Jones Companies");
                Console.WriteLine("6. Dow Jones Historical Companies");
                Console.WriteLine("x. Exit");
                Console.WriteLine("Press ENTER to return to the previous menu");
                var result = Console.ReadKey();

                switch (result.Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.Clear();
                            var response = await client.StockTimeSeries.IndexConstituents.SP500.GetAsync();
                            Console.WriteLine(response.Status);
                            Console.WriteLine(response.ErrorMessage);
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            Console.Clear();
                            var response = await client.StockTimeSeries.IndexConstituents.SP500Historical.GetAsync();
                            Console.WriteLine(response.Status);
                            Console.WriteLine(response.ErrorMessage);
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D3:
                        {
                            Console.Clear();
                            var response = await client.StockTimeSeries.IndexConstituents.Nasdaq100.GetAsync();
                            Console.WriteLine(response.Status);
                            Console.WriteLine(response.ErrorMessage);
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D4:
                        {
                            Console.Clear();
                            var response = await client.StockTimeSeries.IndexConstituents.Nasdaq100Historical.GetAsync();
                            Console.WriteLine(response.Status);
                            Console.WriteLine(response.ErrorMessage);
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D5:
                        {
                            Console.Clear();
                            var response = await client.StockTimeSeries.IndexConstituents.DowJones.GetAsync();
                            Console.WriteLine(response.Status);
                            Console.WriteLine(response.ErrorMessage);
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D6:
                        {
                            Console.Clear();
                            var response = await client.StockTimeSeries.IndexConstituents.DowJonesHistorical.GetAsync();
                            Console.WriteLine(response.Status);
                            Console.WriteLine(response.ErrorMessage);
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.X:
                        applicationLifetime.StopApplication();
                        break;
                    case ConsoleKey.Enter:
                        return;
                    default:
                        break;
                }
            }

        }

        private async Task HistoricalStockDataMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Historical Chart");
                Console.WriteLine("2. Daily Line");
                Console.WriteLine("3. Daily Change and Volume");
                Console.WriteLine("4. Daily Last <x> Days");
                Console.WriteLine("5. Stock Dividends");
                Console.WriteLine("6. Stock Splits");
                Console.WriteLine("x. Exit");
                Console.WriteLine("Press ENTER to return to the main menu");
                var result = Console.ReadKey();

                switch (result.Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.Clear();
                            Console.Write("Enter symbol: ");
                            var symbol = Console.ReadLine();
                            var interval = ParseIntervalInput(GetInterval());
                            var response = await client.StockTimeSeries.HistoricalStockData.HistoricalChart.GetAsync(new HistoricalChartRequest { Symbol = symbol, Interval=interval });
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            Console.Clear();
                            Console.Write("Enter symbol: ");
                            var symbol = Console.ReadLine();
                            var response = await client.StockTimeSeries.HistoricalStockData.DailyLine.GetAsync(new DailyLineRequest{ Symbol = symbol});
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D3:
                        {
                            Console.Clear();
                            Console.Write("Enter symbol: ");
                            var symbol = Console.ReadLine();
                            var response = await client.StockTimeSeries.HistoricalStockData.DailyChangeAndVolume.GetAsync(new DailyChangeAndVolumeRequest{ Symbol = symbol });
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D4:
                        {
                            Console.Clear();
                            Console.Write("Enter symbol: ");
                            var symbol = Console.ReadLine();
                            Console.Write("Enter number of days: ");
                            var numOfDays = int.Parse(Console.ReadLine()); // TODO: handle input
                            var response = await client.StockTimeSeries.HistoricalStockData.DailyLastXDays.GetAsync(new DailyLastXDaysRequest{ Symbol = symbol, NumberOfDays = numOfDays });
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D5:
                        {
                            Console.Clear();
                            Console.Write("Enter symbol: ");
                            var symbol = Console.ReadLine();
                            var response = await client.StockTimeSeries.HistoricalStockData.DailyStockDividend.GetAsync(new StockDividendRequest{ Symbol = symbol });
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D6:
                        {
                            Console.Clear();
                            Console.Write("Enter symbol: ");
                            var symbol = Console.ReadLine();
                            var response = await client.StockTimeSeries.HistoricalStockData.DailyStockSplit.GetAsync(new StockSplitRequest{ Symbol = symbol });
                            Console.WriteLine(JsonConvert.SerializeObject(response.Data));
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.Enter:
                        return;
                    case ConsoleKey.X:
                        applicationLifetime.StopApplication();
                        break;
                }
            }
        }

        private string GetInterval()
        {
            while (true)
            {
                Console.Write("Enter interval (1m, 5m, 15m, 30m, 1h) [5m]:");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1m":
                    case "5m":
                    case "15m":
                    case "30m":
                    case "1h":
                        return input;
                    case "":
                        return "5m";
                    default:
                        Console.WriteLine("Invalid interval, try again. Press ENTER to simply accept the default of '5m'");
                        break;
                }
            }
        }

        private ChartInterval ParseIntervalInput(string input) => input switch
        {
            "1m" => ChartInterval.OneMinute,
            "5m" => ChartInterval.FiveMinutes,
            "15m" => ChartInterval.FifteenMinutes,
            "30m" => ChartInterval.ThirtyMinutes,
            "1h" => ChartInterval.OneHour,
            _ => throw new ArgumentOutOfRangeException(nameof(input), $"Invalid interval: {input}")
        };
        
    }



}
