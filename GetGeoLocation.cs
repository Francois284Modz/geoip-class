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
            
            public string ip {get;set;}
            public string city {get;set;}
            public string region {get;set;}
            public string  country {get;set;}
            public string loc {get;set;}
            public string postal {get;set;}
            
            /* asn */
            public string asn {get;set;}
            public string name {get;set;}
            public string domain {get;set;}
            public string route {get;set;}
            public string type {get;set;}
            public string isp {get;set;}
            public string mcc {get;set;}
            public string mnc {get;set;}

 

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
