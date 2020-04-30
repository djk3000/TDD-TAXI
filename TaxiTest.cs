using System;
using Xunit;

namespace TaxiTest
{
    public class TaxiTest
    {
        [Fact]
        public void TotalTestData()
        {
            TotalFee total = new TotalFee();
            var data = total.GetTotalValue();
            var receipt = "收费6元\n收费7元\n收费13元\n收费7元";
            Assert.Equal(data, receipt);
        }

        [Theory]
        [InlineData("1公里,等待0分钟", "收费6元")]
        [InlineData("3公里,等待0分钟", "收费7元")]
        [InlineData("10公里,等待0分钟", "收费13元")]
        [InlineData("2公里,等待3分钟", "收费7元")]
        public void TotalTaxiFee(string command, string retValue)
        {
            TotalFee total = new TotalFee();
            var result = total.GetTaxiValue(command);
            Assert.Equal(result, retValue);
        }

        [Theory]
        [InlineData("0公里", "6.0")]
        [InlineData("1公里", "6.0")]
        [InlineData("3公里", "6.8")]
        [InlineData("10公里", "13.2")]
        public void Kilometretoll(string command, string retValue)
        {
            Kilometretoll km = new Kilometretoll();
            var result = km.KMtoll(command);
            Assert.Equal(result, retValue);
        }

        [Theory]
        [InlineData("等待0分钟", "0.00")]
        [InlineData("等待3分钟", "0.75")]
        [InlineData("等待10分钟", "2.50")]
        public void WaitFee(string command, string retValue)
        {
            StopWait sw = new StopWait();
            var result = sw.StopWaitFee(command);
            Assert.Equal(result, retValue);
        }
    }
}
