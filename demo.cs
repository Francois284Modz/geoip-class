using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Web;
using Newtonsoft.Json;


namespace Free_GEOIP_By_Francois284Modz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logInButton1_Click(object sender, EventArgs e)
        {
           
                GetGeoLocation.IPData ipdata = new GetGeoLocation().GetIPGeoLocation(logInNormalTextBox1.Text);



                  logInLabel1.Text =  ipdata.query;
                 /*   ipdata.country,
                    ipdata.countryCode,
                    ipdata.city,
                    ipdata.timezone,
                    ipdata.lon,
                    ipdata.lat,
                    ipdata.isp,
                    ipdata.status,
                    ipdata.name;*/

          
        }

    }
}
