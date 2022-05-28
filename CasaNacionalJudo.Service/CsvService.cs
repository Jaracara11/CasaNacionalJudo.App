using CasaNacionalJudo.Core;
using CsvHelper;
using System.Globalization;

namespace CasaNacionalJudo.Service
{
    public class CsvService
    {
        public static void MembersToCsv(List<Member> memberList)
        {
            StreamWriter writer = new($"{FilePathService.CsvPath}\\MemberList.csv");
            CsvWriter csv = new(writer, CultureInfo.InvariantCulture);

            csv.WriteHeader<CsvHeader>();
            csv.NextRecord();

            foreach (var member in memberList)
            {
                csv.WriteField(member.FirstName);
                csv.WriteField(member.LastName);
                csv.WriteField(member.BirthDate);
                csv.WriteField(member.BloodType);
                csv.WriteField(member.Identification);
                csv.WriteField(member.Address);
                csv.WriteField(member.Phone1);
                csv.WriteField(member.Phone2);
                csv.WriteField(member.Email);
                csv.WriteField(member.Belt);
                csv.WriteField(member.SignUpDate);
                csv.WriteField(member.MonthlyFee);
                csv.WriteField(member.AnualFee);
                csv.WriteField(member.TotalAmountDue);
                csv.NextRecord();
            }

            writer.Flush();
            writer.Close();
        }
    }
}