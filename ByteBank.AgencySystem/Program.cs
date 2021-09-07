using ByteBank.AgencySystem.Extensions;
using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.AgencySystem {
  class Program {
    static void Main(string[] args) {
      List<int> ages = new List<int>();

      ages.Add(1);
      ages.Add(15);
      ages.Add(23);
      ages.Add(35);
      ages.AddMore(54, 25, 68, 32);

      for (int i = 0; i < ages.Count; i++) {
        Console.WriteLine(ages[i]);
      }

      Console.WriteLine("The application finished! Key enter to exit!");
      Console.ReadLine();
    }
  }
}
