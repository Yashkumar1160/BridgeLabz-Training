using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.dbconnection
{
    public class DBConnect
    {
        //connection string
        private static readonly string connectionString = "Server=Yash\\SQLEXPRESS;Database=HealthClinic;Trusted_Connection=True;TrustServerCertificate=True";

        public static SqlConnection Connect()
        {
            try
            {
                return new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database connection failed: " + ex.Message);
                throw;
            }
        }

    }
}