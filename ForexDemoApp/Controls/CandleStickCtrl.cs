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

namespace ForexDemoApp.Controls
{
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
                        var metadata = jObj["Meta Data"].ToObject<Dictionary<string, string>>();
                        var timeSeries = jObj[timeSeriesKey].ToObject<Dictionary<string, string>>();

                        if (timeSeries.Count() > 0)
                        {

                        }

                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }
        }
    }
}
