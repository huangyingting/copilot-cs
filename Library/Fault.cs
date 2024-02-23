using System.Data.SqlClient;

namespace CopilotCsharp.Library;

public class Fault
{
    public static void SqlOperation(string connectionString, string userInput)
    {

        string query = "SELECT * FROM Users WHERE Name = '" + userInput + "'";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Read data
            while (reader.Read())
            {
                string name = reader.GetString(0);
                string password = reader.GetString(1);
                Console.WriteLine("Name: {0}\tPassword: {1}", name, password);

            }
        }
    }

    public static void PathOperation(string fileName)
    {
        string path = "uploads/" + fileName;
        File.ReadAllText(path);
    }

    public static void CopyOperation(byte[] input)
    {
        byte[] buffer = new byte[32];
        Buffer.BlockCopy(input, 0, buffer, 0, input.Length);
    }

    public static void ErrorHandlingOpeartion()
    {
        try
        {
            // Operation  
        }
        catch (Exception)
        {
            throw new ApplicationException("Operation failed");
        }
    }
}
