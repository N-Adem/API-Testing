using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixerIOwalkthrough
{
    public static class FixerConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_Url"];
        public static readonly string ApiKey = ConfigurationManager.AppSettings["api_key"];
        public static readonly string AccessKeyUrl = ConfigurationManager.AppSettings["access_key_url_mod"];

        public static string ApiUrlMod { get; internal set; }
    }
}
