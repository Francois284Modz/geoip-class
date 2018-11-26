using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;
using System.Web;
using Newtonsoft.Json;

namespace Free_GEOIP_By_Francois284Modz
{
    class GetGeoLocation
    {

        public class IPData
        {
            public string status { get; set; }
            public string query { get; set; }
            public string country { get; set; }
            public string countryCode { get; set; }
            public string region { get; set; }
            public string regionName { get; set; }
            public string city { get; set; }
            public string zip { get; set; }
            public string lat { get; set; }
            public string lon { get; set; }
            public string timezone { get; set; }
            public string isp { get; set; }
            public string org { get; set; }
            public string name { get; set; }
 

        }

        public IPData GetIPGeoLocation(string IP)
        {
            WebClient client = new WebClient();
            try
            {

                string response = client.DownloadString("http://ip-api.com/json/" + IP);
                IPData ipdata = JsonConvert.DeserializeObject<IPData>(response);
                if (ipdata.status == "fail")
                {
                    throw new Exception("Invalid IP");
                }

                return ipdata;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
