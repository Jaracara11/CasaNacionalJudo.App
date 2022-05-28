using System.Configuration;

namespace CasaNacionalJudo.Service
{
    public class FilePathService
    {
        private static readonly string _excelPath =
             ConfigurationManager.AppSettings["CsvPath"]!.ToString();

        public static string CsvPath { get => _excelPath; }
    }
}
