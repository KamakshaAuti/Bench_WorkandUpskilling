using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop1 {
  class Program {
    static void Main(string[] args) {
      int a;
      
      a = 1;
      while (a <= 15) {
        Console.WriteLine(a);
        a++;
      }
      
      //wait to hit any key to exit the program
      Console.ReadKey();
    }
  }
}