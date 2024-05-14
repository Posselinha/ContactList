namespace ContactList.ContactHandler
{
    public class Contact
    {
        public string _name { get; private set; }
        public string _email { get; private set; }

        public Contact(string name, string email)
        {
            _name = name;
            _email = email;
        }
    }
}