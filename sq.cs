string connectionString =

            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"

            + "Integrated Security=true";

 

        // Provide the query string with a parameter placeholder.

        string queryString =

            "SELECT ProductID, UnitPrice, ProductName from dbo.products "

                + "WHERE UnitPrice > @pricePoint "

                + "ORDER BY UnitPrice DESC;";
using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString ="Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
          + "Integrated Security=true";
        // Define the query with a parameter placeholder
        string queryString = 
            "SELECT ProductID, UnitPrice, ProductName " +
            "FROM dbo.Products " +
            "WHERE UnitPrice > @pricePoint " +
            "ORDER BY UnitPrice DESC;";

        // Specify the parameter value
        int paramValue = 5;

        // Define your SQL Server connection string
        string connectionString = "your_connection_string_here";

        // Create and open the connection inside a using block
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create the command and add the parameter
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@pricePoint", paramValue);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Read and display the results
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1:C}\t{2}",
                        reader["ProductID"],
                        reader["UnitPrice"],
                        reader["ProductName"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
