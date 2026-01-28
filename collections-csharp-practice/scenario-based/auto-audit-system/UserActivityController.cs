using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.auto_audit_system
{
    internal class UserActivityController
    {
        //login action should be audited
        [AuditTrail("User Login")]
        public void Login()
        {
            Console.WriteLine("User logged in");
        }

        //file upload action should be audited
        [AuditTrail("File Upload")]
        public void UploadFile()
        {
            Console.WriteLine("File uploaded");
        }

        //delete action should be audited
        [AuditTrail("File Delete")]
        public void DeleteFile()
        {
            Console.WriteLine("File deleted");
        }

        //this method is not audited
        public void InternalCleanup()
        {
            Console.WriteLine("Internal cleanup process");
        }
    }
}