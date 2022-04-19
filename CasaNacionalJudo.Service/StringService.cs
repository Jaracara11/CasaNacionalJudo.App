namespace CasaNacionalJudo.Service
{
    public static class StringService
    {
        public static string FirstCharToUpper(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                char[] stringArray = input.ToCharArray();
                stringArray[0] = char.ToUpper(stringArray[0]);

                return new string(stringArray);
            }

            return input;
        }

        public static DateTime ConvertToDateTime(string str)
        {
            DateTime finaldate; string sDateTime;

            try
            {
                finaldate = Convert.ToDateTime(str);
            }
            catch (Exception)
            {
                string[] sDate = str.Split('-');
                sDateTime = sDate[1] + '-' + sDate[0] + '-' + sDate[2];
                finaldate = Convert.ToDateTime(sDateTime);
            }

            return finaldate;
        }
    }
}
