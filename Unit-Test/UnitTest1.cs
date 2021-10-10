using System;
using Xunit;

namespace Unit_Test
{
   public class UnitTest1
   {
      [Fact]
      public void Test1()
      {
         Assert.Equal(1, 1);
      }
      public void Test1()
      {
         Assert.Equal(2, 2);
      }
   }
}
