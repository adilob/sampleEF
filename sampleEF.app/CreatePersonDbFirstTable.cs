using System;
using System.Data.SqlClient;

namespace sampleEF.app
{
  public class CreatePersonDbFirstTable
  {
    public void Test()
    {
      Console.WriteLine("hello from create bla bla bla");
    }
    public void CreateTable()
    {
      try
      {

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        builder.DataSource = "mssql";
        builder.UserID = "sa";
        builder.Password = "cJ3\"fC7>oN3;iN4>";
        builder.InitialCatalog = "db_test";

        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
        {
          connection.Open();

          String sql = @"
            CREATE TABLE testEF.PersonDbFirst (
                person_id INT PRIMARY KEY IDENTITY (1, 1),
                first_name VARCHAR (50) NOT NULL,
                last_name VARCHAR (50) NOT NULL,
                phone VARCHAR(20)
            );
          ";

          using (SqlCommand command = new SqlCommand(sql, connection))
          {
            using (SqlDataReader reader = command.ExecuteReader())
            {
              while (reader.Read())
              {
                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
              }
            }
          }
        }
      }
      catch (SqlException e)
      {
        Console.WriteLine(e.ToString());
      }

      Console.WriteLine("\nDone. Press enter.");
      Console.ReadLine();
    }
  }
}