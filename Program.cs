using System;

namespace AdvanceAddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Welcome To Adderess Book Program------------");
            AdvanceAddressBookSystem.AddressBook.GetContact();
            AdvanceAddressBookSystem.AddressBook.ListContact();
        }
    }
}
