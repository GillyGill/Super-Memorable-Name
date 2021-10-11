using System;
using Xunit;

namespace Unit_Test
{
   public class UnitTest1
   {
      [Fact]
      public void Test1()
      {
         // Arrange
         string expected = "Hello, ";
         Project1.main test = new();
         // Act
         string actual = test.greeting();
         // Assert
         Assert.Equal(expected, actual);
      }
      [Fact]
      public void Test2()
      {
         // Arrange
         string expected = "Goodbye ";
         Project1.main test = new();
         // Act
         string actual = test.goodbye();
         // Assert
         Assert.Equal(expected, actual);
      }
   }
}
