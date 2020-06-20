using HelloWorldnew;
using System;
using Xunit;

namespace HelloTests
{
    public class HelloTest
    {
        [Fact]
        public void DisplayMessageShouldReturnValidString()
        {
           
            string expected = "Hello world!";
            string programResult = MessageGenerator.displayMessage();
            Assert.Equal(expected, programResult);
        }
    }
}
