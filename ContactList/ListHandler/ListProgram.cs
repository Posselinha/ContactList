using ContactList.ContactHandler;
using ContactList.Validation;

namespace ContactList.ListHandler
{
    public static class ListProgram
    {
        private static List<string[]> SavedContacts = new List<string[]>();

        public static void Start()
        {
            bool exitProgram = false;
            do
            {
                Console.WriteLine("O que você deseja fazer?\n[1] - Ver lista de Contatos\n[2] - Adicionar Contatos\n[3] - Remover Contatos\n[4] - Sair\n");
                int parsedInput = UserInputValidator.ParseInput(Console.ReadLine());

                switch (parsedInput)
                {
                    case 1:
                        ListVisualizer.ShowContacts(ContactCreator.CreateContactList(SavedContacts));
                        break;
                    case 2:
                        AddContact();
                        break;
                    case 3:
                        RemoveContact();
                        break;
                    case 4:
                        exitProgram = true;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Pressione qualquer botão para continuar!");
                Console.ReadKey();
                Console.Clear();
            } while (!exitProgram);
        }

        private static void AddContact()
        {
            Console.WriteLine("Quantos contatos você quer adicionar?");
            int addQuantity = UserInputValidator.ParseInput(Console.ReadLine());
            int loopIncrement = 0;
            while (loopIncrement < addQuantity)
            {
                loopIncrement++;
                Console.WriteLine($"Contato #{loopIncrement}");

                Console.WriteLine("Qual o nome do contato?");
                string? inputName = Console.ReadLine();
                string? contactName = UserInputValidator.ValidateIfNullOrEmpty(inputName, "Nome");

                Console.WriteLine("Qual o email do contato?");
                string? inputEmail = Console.ReadLine();
                string? contactEmail = UserInputValidator.ValidateIfNullOrEmpty(inputEmail, "Email");

                string[] contactArray = [contactName, contactEmail];

                SavedContacts.Add(contactArray);
            }
        }

        private static void RemoveContact()
        {
            if (ListVisualizer.ShowContacts(ContactCreator.CreateContactList(SavedContacts)))
            {
                Console.WriteLine("Informe o índice do contato que você deseja excluir!");
                int parsedInput = UserInputValidator.ParseInput(Console.ReadLine()) - 1;
                if (parsedInput > -1)
                {
                    Console.WriteLine("Removendo contato...");
                    SavedContacts.RemoveAt(parsedInput);
                }
            }
        }


    }
}