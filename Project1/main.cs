using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
   class main
   {
      static public string greeting()
      {
         return "Hello, ";
      }
      static public string goodbye()
      {
         return "Goodbye";
      }
      static void Main(string[] args)
      {
         System.Console.WriteLine(greeting() + "World!");
      }
   }
}
