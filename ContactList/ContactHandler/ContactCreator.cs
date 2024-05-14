namespace ContactList.ContactHandler
{
    public static class ContactCreator
    {
        public static Contact CreateContact(string[] contact)
        {
            Contact newContact = new Contact(contact[0], contact[1]);
            return newContact;
        }

        public static List<Contact> CreateContactList(List<string[]> contacts)
        {
            List<Contact> contactsList = new List<Contact>();
            foreach (string[] contact in contacts)
            {
                contactsList.Add(CreateContact(contact));
            }
            return contactsList;
        }
    }
}