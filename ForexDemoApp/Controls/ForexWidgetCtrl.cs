using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ForexDemoApp.Controls
{
    public partial class ForexWidgetCtrl : UserControl
    {
        public string _uri { get; set; }
        public string _function { get; set; }
        public string _fromCurrency { get; set; }
        public string _toCurrency { get; set; }

        // Create a New HttpClient object.
        HttpClient client;

        public ForexWidgetCtrl(string uri, string function, string fromCurrency, string toCurrency, string apikey)
        {
            InitializeComponent();

            _function = function;
            _fromCurrency = fromCurrency;
            _toCurrency = toCurrency;
            _uri = uri + $"function={function}&from_currency={_fromCurrency}&to_currency={_toCurrency}&apikey={apikey}";
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(62, 62, 66);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(47, 47, 48);
        }

        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(204, 100, 80);
        }

        private async Task CallApi()
        {
            using (client = new HttpClient())
            {
                try
                {
                    string responseBody = await client.GetStringAsync(_uri);
                    var jObj = JObject.Parse(responseBody);
                    var metadata = jObj["Realtime Currency Exchange Rate"].ToObject<Dictionary<string, string>>();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private async void ForexWidgetCtrl_Load(object sender, EventArgs e)
        {
            await CallApi();
        }
    }
}
