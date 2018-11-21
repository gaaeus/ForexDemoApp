using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using ForexDemoApp.Classes;
using System.Collections;

namespace ForexDemoApp.Controls
{
    // sample https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=MSFT&interval=5min&apikey=demo

    public partial class CandleStickCtrl : UserControl
    {
        string _uriSymbol { get; set; }
        string _function { get; set; }
        string _symbol { get; set; }
        string _interval { get; set; }
        string _outputsize { get; set; }

        // Create a New HttpClient object.
        HttpClient client;

        public CandleStickCtrl(string uri, string function, string symbol, string interval, string apikey, string outputsize = "")
        {
            _function = $"function={function}";
            _symbol = $"symbol={symbol}";
            _interval = $"interval={interval}";
            _outputsize = outputsize;
            _uriSymbol = uri + $"{_function}&{_symbol}&{_interval}&apikey={apikey}";
            InitializeComponent();
        }

        private async Task CallApi()
        {
            using (client = new HttpClient())
            {
                try
                {
                    string responseBody = await client.GetStringAsync(_uriSymbol);
                    var jObj = JObject.Parse(responseBody);
                    var timeSeriesKey = $"Time Series ({_interval.Replace("interval=", string.Empty)})";
                    if (jObj.ContainsKey("Meta Data") && jObj.ContainsKey(timeSeriesKey))
                    {
                        var timeKeys = new List<string>();
                        var indicatorsDataSource = new ArrayList();
                        foreach (var item in jObj[timeSeriesKey].ToList())
                        {
                            var timeKey = ((JProperty)(item)).Name;
                            timeKeys.Add(timeKey);

                            // Get the values for each timeKey and add to datasource
                            indicatorsDataSource.Add(new Record(
                                    indicatorsDataSource.Count + 1,
                                    timeKey,
                                    Convert.ToDouble(item.ElementAt(0).ToObject<Dictionary<string, string>>()["1. open"]),
                                    Convert.ToDouble(item.ElementAt(0).ToObject<Dictionary<string, string>>()["2. high"]),
                                    Convert.ToDouble(item.ElementAt(0).ToObject<Dictionary<string, string>>()["3. low"]),
                                    Convert.ToDouble(item.ElementAt(0).ToObject<Dictionary<string, string>>()["4. close"])
                                ));
                        }

                        chart1.Series["Series1"].XValueMember = "TimeStamp";
                        chart1.Series["Series1"].YValueMembers = "High, Low, Open, Close";
                        chart1.Series["Series1"].CustomProperties = "PrieceDownColor=Red,PriceUpColor=green";
                        chart1.Series["Series1"]["ShowOpenClose"] = "Both";
                        chart1.DataManipulator.IsStartFromFirst = true;
                        chart1.DataSource = indicatorsDataSource;
                        chart1.DataBind();
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }
        }

        private async void CandleStickCtrl_Load(object sender, EventArgs e)
        {
            await CallApi();
        }
    }
}
