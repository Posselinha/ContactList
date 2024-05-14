namespace ContactList.Validation
{
    public static class UserInputValidator
    {
        public static int ParseInput(string? userInput)
        {
            bool isInputValid = int.TryParse(userInput, out int validInput);

            if (isInputValid)
            {
                return validInput;
            }
            else
            {
                Console.WriteLine("Insira um valor válido!");
                return 0;
            }
        }

        public static string ValidateIfNullOrEmpty(string? userInput, string nameOfField)
        {
            return string.IsNullOrEmpty(userInput) ? $"{nameOfField} Desconhecido" : userInput;
        }
    }
}