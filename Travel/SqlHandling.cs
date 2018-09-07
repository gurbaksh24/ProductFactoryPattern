using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Travel
{
    class SqlHandling : IRepository
    {
        public void InsertProduct(params string[] members)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = @"Data Source=TAVDESK060;Initial Catalog=travel;Integrated Security=True";
                sqlConnection.Open();
                string query = "Insert into "+members[2]+"(Id,Name,IsBooked) values(@id,@name,@isBooked)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@id", int.Parse(members[0])));
                sqlCommand.Parameters.Add(new SqlParameter("@name", members[1]));
                sqlCommand.Parameters.Add(new SqlParameter("@isBooked", members[3]));
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Data Saved");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void UpdateProduct(int productId, bool bookingStatus, string product)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = @"Data Source=TAVDESK060;Initial Catalog=travel;Integrated Security=True";
                sqlConnection.Open();
                string query = "Update " + product + " set IsBooked=@isBooked where Id=@id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@id", productId));
                sqlCommand.Parameters.Add(new SqlParameter("@isBooked", bookingStatus.ToString()));
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Booked");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
