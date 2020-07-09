using System;
using Xunit;
using static UnitTest1.Program;
namespace MultiTest
{
    public class UnitTest1
    {
           public void Test1()
        {
            //Arrange
            string input = "cat";
            //Act
            int outputFromMethod = MultiplyInputNumber(input);
            //Assert
            Assert.Equal(0, outputFromMethod);
        }
    }
}
