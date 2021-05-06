using System;
using sampleEF.app;

namespace sampleEF.app
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      CreatePersonDbFirstTable c = new CreatePersonDbFirstTable();
      c.Test();
    }
  }
}
