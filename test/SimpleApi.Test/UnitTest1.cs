using System;
using Xunit;
using SimpleApi.Controllers;

namespace SimpleApi.Test
{
    public class UnitTest1
    {
        WeatherForecastController wc= new WeatherForecastController();

        [Fact]
        public void GetReturnTemp()
        {

            var returnValue=wc.Get2();

            Assert.Equal("Atul Jain",returnValue);

            
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
