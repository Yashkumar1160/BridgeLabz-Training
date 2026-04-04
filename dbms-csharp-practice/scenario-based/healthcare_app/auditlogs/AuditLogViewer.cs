using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.dbconnection;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.auditlogs
{
    public class AuditLogViewer
    {
        public static void ViewAuditLogs(string tableName = null, string userName = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            try
            {

                using (SqlConnection conn = DBConnect.Connect())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("ViewAuditLogs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@table_name", (object)tableName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@user_name", (object)userName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@from_date", (object)fromDate ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@to_date", (object)toDate ?? DBNull.Value);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine("Audit Logs:");
                            Console.WriteLine("ID\tTable\tRecord\tAction\tUser\tDate");
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["audit_id"]}\t{reader["table_name"]}\t{reader["record_id"]}\t{reader["action"]}\t{reader["user_name"]}\t{reader["action_date"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching audit logs: " + ex.Message);
            }

            Console.WriteLine("Press any key to return to main menu...");
            Console.ReadKey();
        }
    }
}