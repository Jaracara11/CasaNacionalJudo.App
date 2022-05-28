using CsvHelper.Configuration.Attributes;

namespace CasaNacionalJudo.Core
{
    public class CsvHeader
    {
        [Index(0)]
        [Name("FirstName")]
        public string FirstName { get; set; } = string.Empty;

        [Index(1)]
        [Name("LastName")]
        public string LastName { get; set; } = string.Empty;

        [Index(2)]
        [Name("BirthDate")]
        public string BirthDate { get; set; } = string.Empty;

        [Index(3)]
        [Name("BloodType")]
        public string BloodType { get; set; } = string.Empty;

        [Index(4)]
        [Name("Identification")]
        public string Identification { get; set; } = string.Empty;

        [Index(5)]
        [Name("Address")]
        public string Address { get; set; } = string.Empty;

        [Index(6)]
        [Name("Phone1")]
        public string Phone1 { get; set; } = string.Empty;

        [Index(7)]
        [Name("Phone2")]
        public string Phone2 { get; set; } = string.Empty;

        [Index(8)]
        [Name("Email")]
        public string Email { get; set; } = string.Empty;

        [Index(9)]
        [Name("Belt")]
        public string Belt { get; set; } = string.Empty;

        [Index(10)]
        [Name("SignUpDate")]
        public string SignUpDate { get; set; } = string.Empty;

        [Index(11)]
        [Name("MonthlyFee")]
        public decimal MonthlyFee { get; set; }

        [Index(12)]
        [Name("AnualFee")]
        public decimal AnualFee { get; set; }

        [Index(13)]
        [Name("TotalAmountDue")]
        public decimal TotalAmountDue { get; set; }
    }
}

