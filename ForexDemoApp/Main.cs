using ForexDemoApp.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForexDemoApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadControls();
        }

        private void LoadControls()
        {
            var uri = ConfigurationManager.AppSettings["URL"]; 
            var function = ConfigurationManager.AppSettings["function"];
            var apikey = ConfigurationManager.AppSettings["apikey"];
            ForexWidgetCtrl w = new ForexWidgetCtrl(uri, function, "GBP", "EUR", apikey);

            flowLayoutPanel1.Controls.Add(w);

            w = new ForexWidgetCtrl(uri, function, "BRL", "GBP", apikey);
            flowLayoutPanel1.Controls.Add(w);
        }
    }
}
