using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace FixerIOwalkthrough
{
    public class FLService
    {
        public FixerLatestCallManager FixerLatestCallManager { get; set; } = new FixerLatestCallManager();
        public FixerLatestDTO FixerLatestDTO { get; set; } = new FixerLatestDTO();
        public string LiveRates { get; set; }
        public JObject JasonRates { get; set; }

        private Dictionary<string, double> ratesMap = new Dictionary<string, double>();
        private bool isRate;
        public FLService() {
            LiveRates = FixerLatestCallManager.GetLatestRates();

            FixerLatestDTO.DeserialiseRates(LiveRates);
            JasonRates = JsonConvert.DeserializeObject<JObject>(LiveRates);
        }

        public bool BaseRateIsEuro() {
            return (JasonRates["base"].ToString() == "EUR"); 
        }

        public bool CheckThatTheCurrencyIs(string currency) {
            string tempRate = "";
            foreach(var rate in JasonRates["rates"]) {
                tempRate = rate.ToString().Substring(1, 3);
                isRate = (tempRate == currency);
                if (tempRate == currency){ break; }
            }
            return isRate;
        }
        public bool CompareTwoRates(string rateOne, string rateTwo) {
            string[] rateIndex = { rateOne, rateTwo};
            string tempRate = "";
            string tempValue = "";
            for (int i = 0; i < rateIndex.Length; i++) {
                foreach (var rate in JasonRates["rates"])
                {
                    tempRate = rate.ToString().Substring(1, 3);
                    if (tempRate == rateIndex[i])
                    {
                        tempValue = rate.ToString().Substring(6, 7);
                        ratesMap.Add(tempRate, Convert.ToDouble(tempValue));                 
                    }
                }
            }
            return (ratesMap[rateIndex[0]] > ratesMap[rateIndex[1]]);
        }
    }

}
