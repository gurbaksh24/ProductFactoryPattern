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
        public void InsertProduct(int productId, string productName, IProduct product, bool bookingStatus, double fare, double actualPrice)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = @"Data Source=TAVDESK060;Initial Catalog=travel;Integrated Security=True";
                sqlConnection.Open();
                string query = "Insert into "+product.GetType().Name+"(Id,Name,IsBooked,Fare,ActualPrice) values(@id,@name,@isBooked,@fare,@actualPrice)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@id", productId));
                sqlCommand.Parameters.Add(new SqlParameter("@name", productName));
                sqlCommand.Parameters.Add(new SqlParameter("@isBooked", bookingStatus.ToString()));
                sqlCommand.Parameters.Add(new SqlParameter("@fare", fare));
                sqlCommand.Parameters.Add(new SqlParameter("@actualPrice", actualPrice));
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

        public void UpdateProduct(int productId, bool bookingStatus, IProduct product)
        {
            SqlConnection sqlConnection = null;
            try
            {
                double actualFare = GetFare(productId, product);
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = @"Data Source=TAVDESK060;Initial Catalog=travel;Integrated Security=True";
                sqlConnection.Open();
                string query = "Update " + product.GetType().Name + " set IsBooked=@isBooked,Fare=@fare where Id=@id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@id", productId));
                sqlCommand.Parameters.Add(new SqlParameter("@isBooked", bookingStatus.ToString()));
                sqlCommand.Parameters.Add(new SqlParameter("@fare", actualFare));
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
        private double GetFare(int productId, IProduct product)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = @"Data Source=TAVDESK060;Initial Catalog=travel;Integrated Security=True";
                sqlConnection.Open();
                string query = "Select * from " + product.GetType().Name + " where Id=@id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@id", productId));
                SqlDataReader dr = sqlCommand.ExecuteReader();
                double price=0;
                if (dr.Read())
                {
                    FareStrategy fareStrategy = new FareStrategy();
                    price = fareStrategy.CalculateFare(double.Parse(dr[4].ToString()),product);
                }
                Console.WriteLine("Booked");
                return price;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
