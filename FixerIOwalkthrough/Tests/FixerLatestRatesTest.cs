

using NUnit.Framework;

namespace FixerIOwalkthrough
{
    class FixerLatestRatesTest
    {
        private FLService _fixerLatestRate = new FLService();

        [Test]
        public void WebCallSuccessCheck() {
            Assert.That(_fixerLatestRate.FixerLatestDTO.LatestRates.success);
        }
        [Test]
        public void WebCheckTheBaseIsEuro() {
            Assert.AreEqual(true, _fixerLatestRate.BaseRateIsEuro());
        }
        [Test]
        public void WebCheckTheRateExists() {
            Assert.AreEqual(true, _fixerLatestRate.CheckThatTheCurrencyIs("AFN"));
        }
        [Test]
        public void WebCheckAndCompareRates()
        {
            Assert.AreEqual(true, _fixerLatestRate.CompareTwoRates("AFN", "AED"));
        }
    }
}
