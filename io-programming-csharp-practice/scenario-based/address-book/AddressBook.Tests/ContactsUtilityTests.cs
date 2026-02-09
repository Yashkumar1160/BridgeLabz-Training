using Microsoft.VisualStudio.TestTools.UnitTesting;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.addressbookfolder;
namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.Tests;

[TestClass]
public class ContactsUtilityTests
{
    private ContactsUtilityImpl utility;

    [TestInitialize]
    public void Setup()
    {
        utility = new ContactsUtilityImpl();
    }

    //create contact
    private Contact CreateContact(string first, string last)
    {
        return new Contact(first, last, "Addr", "City", "State", "123456", "test@mail.com", "9876543210");
    }

    //Add contact
    [TestMethod]
    public void AddNewContact_ShouldIncreaseCount()
    {
        utility.AddNewContact(CreateContact("John", "Doe"));

        Assert.AreEqual(1, utility.TotalContacts());
    }

    //Duplicate contact
    [TestMethod]
    [ExpectedException(typeof(DuplicateAddressBookException))]
    public void DuplicateContact_ShouldThrow()
    {
        var c = CreateContact("John", "Doe");

        utility.AddNewContact(c);
        utility.AddNewContact(c);
    }

    //Delete contact 
    [TestMethod]
    public void DeleteContact_ShouldDecreaseCount()
    {
        utility.AddNewContact(CreateContact("John", "Doe"));

        utility.DeletePersonContact("John", "Doe");

        Assert.AreEqual(0, utility.TotalContacts());
    }

    //Sorting by name
    [TestMethod]
    public void SortByName_ShouldSortAlphabetically()
    {
        utility.AddNewContact(CreateContact("Zack", "A"));
        utility.AddNewContact(CreateContact("Adam", "B"));

        utility.SortByPersonName();

        Assert.AreEqual("Adam", utility.contacts[0].FirstName);
    }
}
