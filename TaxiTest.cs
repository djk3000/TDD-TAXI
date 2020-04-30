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
            var receipt = "�շ�6Ԫ\n�շ�7Ԫ\n�շ�13Ԫ\n�շ�7Ԫ";
            Assert.Equal(data, receipt);
        }

        [Theory]
        [InlineData("1����,�ȴ�0����", "�շ�6Ԫ")]
        [InlineData("3����,�ȴ�0����", "�շ�7Ԫ")]
        [InlineData("10����,�ȴ�0����", "�շ�13Ԫ")]
        [InlineData("2����,�ȴ�3����", "�շ�7Ԫ")]
        public void TotalTaxiFee(string command, string retValue)
        {
            TotalFee total = new TotalFee();
            var result = total.GetTaxiValue(command);
            Assert.Equal(result, retValue);
        }

        [Theory]
        [InlineData("0����", "6.0")]
        [InlineData("1����", "6.0")]
        [InlineData("3����", "6.8")]
        [InlineData("10����", "13.2")]
        public void Kilometretoll(string command, string retValue)
        {
            Kilometretoll km = new Kilometretoll();
            var result = km.KMtoll(command);
            Assert.Equal(result, retValue);
        }

        [Theory]
        [InlineData("�ȴ�0����", "0.00")]
        [InlineData("�ȴ�3����", "0.75")]
        [InlineData("�ȴ�10����", "2.50")]
        public void WaitFee(string command, string retValue)
        {
            StopWait sw = new StopWait();
            var result = sw.StopWaitFee(command);
            Assert.Equal(result, retValue);
        }
    }
}
