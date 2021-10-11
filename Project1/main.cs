using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
   public class main
   {
      public main() { }
      public string greeting()
      {
         return "Hello, ";
      }
      public string goodbye()
      {
         return "Something completely random";
      }
      static void Main(string[] args)
      {
         main example = new();
         System.Console.WriteLine(example.greeting() + "World!");
      }
   }
}
