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
        string _uriBuy { get; set; }
        string _uriSell { get; set; }
        string _function { get; set; }
        string _fromCurrency { get; set; }
        string _toCurrency { get; set; }

        // Create a New HttpClient object.
        HttpClient client;

        public ForexWidgetCtrl(string uri, string function, string fromCurrency, string toCurrency, string apikey)
        {
            InitializeComponent();

            _function = function;
            _fromCurrency = fromCurrency;
            _toCurrency = toCurrency;
            _uriBuy = uri + $"function={function}&from_currency={_fromCurrency}&to_currency={_toCurrency}&apikey={apikey}";
            _uriSell = uri + $"function={function}&from_currency={_toCurrency}&to_currency={_fromCurrency}&apikey={apikey}";
            lblPair.Text = $"{_fromCurrency}/{_toCurrency}";
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
                    string responseBody = await client.GetStringAsync(_uriBuy);
                    var jObj = JObject.Parse(responseBody);
                    var metadata = jObj["Realtime Currency Exchange Rate"].ToObject<Dictionary<string, string>>();
                    lblBuyRate.Text = metadata["5. Exchange Rate"];
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    string responseBody = await client.GetStringAsync(_uriSell);
                    var jObj = JObject.Parse(responseBody);
                    var metadata = jObj["Realtime Currency Exchange Rate"].ToObject<Dictionary<string, string>>();
                    lblSellRate.Text = metadata["5. Exchange Rate"];
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
