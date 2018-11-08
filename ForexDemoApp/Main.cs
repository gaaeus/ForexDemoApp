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

            w.Location = new Point(10, 50);
            w.Visible = true;
            Controls.Add(w);
        }
    }
}
