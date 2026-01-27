using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{
    public class DatabaseConnection
    {
        //variable to check connection status
        public bool IsConnected { get; private set; }

        //method to connect database
        public void Connect()
        {
            IsConnected = true;
        }

        //method to disconnect database
        public void Disconnect()
        {
            IsConnected = false;
        }
    }
}
