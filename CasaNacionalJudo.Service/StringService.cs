namespace CasaNacionalJudo.Service
{
    public static class StringService
    {
        public static string FirstCharToUpper(string input)
        {
            char[] stringArray = input.ToCharArray();
            stringArray[0] = char.ToUpper(stringArray[0]);

            return new string(stringArray);
        }
    }
}
