using ContactList.ContactHandler;

namespace ContactList.ListHandler
{
    public static class ListVisualizer
    {
        public static string ShowContact(Contact contact) => $"Nome: {contact._name}\nEmail: {contact._email}";

        public static bool ShowContacts(List<Contact> contactsList)
        {
            if (contactsList.Count() > 0)
            {
                int loopIncrement = 1;
                foreach (Contact contact in contactsList)
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine($"Contato #{loopIncrement}\n{ShowContact(contact)}");
                    Console.WriteLine("-------------------");
                    Console.WriteLine();

                    loopIncrement++;
                }
                return true;
            }
            Console.WriteLine("Sua lista ainda não possui nenhum contato!");
            return false;
        }
    }
}