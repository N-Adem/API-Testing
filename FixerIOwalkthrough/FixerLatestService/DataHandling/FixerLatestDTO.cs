using Newtonsoft.Json;

namespace FixerIOwalkthrough
{
    public class FixerLatestDTO
    {
        //This class is the model of the data returned by the API call.
        public LatestRatesRoot LatestRates { get; set; }

        internal void DeserialiseRates(string liveRates)
        {
            LatestRates = JsonConvert.DeserializeObject<LatestRatesRoot>(liveRates);
        }


    }
}
