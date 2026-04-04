using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.dbconnection;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.backup
{
    //UC-6.2->Database Backup
    public class BackupDatabase
    {
        public static void TriggerBackup()
        {
            //try block
            try
            {
                //Sql Connection
                using (SqlConnection connection = DBConnect.Connect())
                {
                    //open connection
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("BackupCriticalTables", connection))
                    {
                        //Stored Procedure
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Database backup completed successfully at " + DateTime.Now);
                    }
                }
            }
            //catch block
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught: " + ex.Message);
            }
        }
    }
}