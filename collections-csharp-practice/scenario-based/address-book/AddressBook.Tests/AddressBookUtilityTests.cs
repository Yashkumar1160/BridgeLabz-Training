using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.addressbookfolder;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.Tests;

[TestClass]
public class AddressBookUtilityTests
{
    private AddressBookUtilityImpl utility;

    [TestInitialize]
    public void Setup()
    {
        utility = new AddressBookUtilityImpl();
    }

    //Add  address book
    [TestMethod]
    public void AddAddressBook_ShouldWork()
    {
        var book = new AddressBook("Friends");

        utility.AddAddressBook(book);

        Assert.IsTrue(true); 
    }

    //Duplicate address book
    [TestMethod]
    [ExpectedException(typeof(DuplicateAddressBookException))]
    public void DuplicateAddressBook_ShouldThrow()
    {
        var book = new AddressBook("Friends");

        utility.AddAddressBook(book);
        utility.AddAddressBook(book); 
    }

    //Select address book
    [TestMethod]
    public void SelectAddressBook_ShouldReturnCorrectBook()
    {
        var book = new AddressBook("Office");

        utility.AddAddressBook(book);

        var result = utility.SelectAddressBook("Office");

        Assert.AreEqual("Office", result.AddressBookName);
    }
}
