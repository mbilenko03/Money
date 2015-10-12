using System;
using System.Collections.Generic;

namespace Money_Converter
{
  class Program
  {
    static void Main()
    {
      Console.Write("$");
      double uValue;
      if (double.TryParse(Console.ReadLine(), out uValue))
      {
        List<string> uchange = ReadChange();
      }
      else
      {
        Console.WriteLine("Input Invalid");
      }
    }

    static List<string> ReadChange()
    {
      Console.WriteLine("Please enter the type of change you have one by one. Example: penny(hit enter), 1 dollar(hit enter)");
      Console.WriteLine("When done, type done");
      List<string> uChange = new List<string>();
      int i = 0;
      do
      {
        uChange[i] = Console.ReadLine();
        i++;
      } while (uChange[i] == "done");

      uChange.RemoveAt(i);
      return uChange;
    }

    static void ParseChange()
    {
      
    }

  }
}
