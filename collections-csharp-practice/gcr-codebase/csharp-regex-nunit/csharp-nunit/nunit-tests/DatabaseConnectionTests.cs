using class_library;
using NUnit.Framework;

namespace nunit_tests
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        DatabaseConnection db;

        //runs before every test
        [SetUp]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        //runs after every test
        [TearDown]
        public void TearDown()
        {
            db.Disconnect();
        }

        //test if connection is established
        [Test]
        public void Database_Connected_Test()
        {
            Assert.IsTrue(db.IsConnected);
        }

        //test if connection is closed
        [Test]
        public void Database_Disconnected_Test()
        {
            db.Disconnect();
            Assert.IsFalse(db.IsConnected);
        }
    }
}
