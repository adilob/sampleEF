using System;
using sampleEF.app;
using sampleEF.data.Models;
using sampleEF.domain.Factories;

namespace sampleEF.app
{
  class Program
  {
    static void Main(string[] args)
    {
      var c = new CreatePersonDbFirstTable();
      c.CreateDb("testdb");
      c.CreatePersonDbFirstTableOnDb("testdb");

      CreateNewPersonDbFirst();
    }

    private static void CreateNewPersonDbFirst()
    {
      using (var db = new testdbContext())
      {
        db.Add(new PersonDbFirst
        {
          FirstName = "Adilo",
          LastName = "Bertoncello",
          Phone = "+5551980659965"
        });

        db.SaveChanges();
      }
    }
  }
}
