using System;
using Xunit;
using static lab03-challenges.Program;
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
