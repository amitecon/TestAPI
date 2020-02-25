using System;
using Xunit;
using simapleAPI.Controllers;

namespace simapleapi.test
{
    public class UnitTest1
    {
        ValuesController controller=new ValuesController();

         [Fact]
        public void GetReturnValueByName()
        {
            var returnValue=controller.Get(1);
            Assert.Equal("Amit",returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
