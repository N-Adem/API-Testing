using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixerIOwalkthrough
{
    public class FixerLatestCallManager
    {
        private IRestClient _client;
        public FixerLatestCallManager() {
            _client = new RestClient(FixerConfigReader.BaseUrl);
        }

        internal string GetLatestRates()
        {
            var request = new RestRequest("latest");
            request.AddParameter("access_key", FixerConfigReader.ApiKey);
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
