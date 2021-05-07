using System;
using System.Data;
using System.Data.SqlClient;

namespace sampleEF.app
{
  public class CreatePersonDbFirstTable
  {
    public void Test()
    {
      Console.WriteLine("hello from create bla bla bla");
    }

    public void CreateDb(string db)
    {
      try
      {

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        builder.DataSource = "mssql";
        builder.UserID = "sa";
        builder.Password = "cJ3\"fC7>oN3;iN4>";

        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
        {
          connection.Open();

          String sql = @"
              IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'testdb')
              BEGIN
                  CREATE DATABASE [testdb];
              END";

          using (SqlCommand command = new SqlCommand(sql, connection))
          {
            command.ExecuteNonQuery();
          }

          connection.Close();
        }
      }
      catch (SqlException e)
      {
        Console.WriteLine(e.ToString());
      }

      Console.WriteLine("Done");
    }
    public void CreatePersonDbFirstTableOnDb(string database)
    {
      try
      {

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        builder.DataSource = "mssql";
        builder.UserID = "sa"; // just a test. In a real world you should avoid use this sa user
        builder.Password = "cJ3\"fC7>oN3;iN4>";
        builder.InitialCatalog = database;

        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
        {
          connection.Open();

          String sql = @"
          IF NOT EXISTS(SELECT * FROM sysobjects WHERE name = 'PersonDbFirst' and xtype='U')
          BEGIN
              CREATE TABLE PersonDbFirst (
                  person_id INT PRIMARY KEY IDENTITY (1, 1),
                  first_name VARCHAR (50) NOT NULL,
                  last_name VARCHAR (50) NOT NULL,
                  phone VARCHAR(20)
              );
          END";

          using (SqlCommand command = new SqlCommand(sql, connection))
          {
            command.ExecuteNonQuery();
          }

          connection.Close();
        }
      }
      catch (SqlException e)
      {
        Console.WriteLine(e.ToString());
      }

      Console.WriteLine("Done");
    }
  }
}