using class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ms_tests
{
    [TestClass]
    public class DatabaseConnectionTests
    {
        DatabaseConnection db;

        //runs before every test
        [TestInitialize]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        //runs after every test
        [TestCleanup]
        public void Cleanup()
        {
            db.Disconnect();
        }

        //test if connection is established
        [TestMethod]
        public void Database_Connected_Test()
        {
            Assert.IsTrue(db.IsConnected);
        }

        //test if connection is closed
        [TestMethod]
        public void Database_Disconnected_Test()
        {
            db.Disconnect();
            Assert.IsFalse(db.IsConnected);
        }
    }
}
