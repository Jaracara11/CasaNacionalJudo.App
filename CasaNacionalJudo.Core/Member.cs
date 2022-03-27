namespace CasaNacionalJudo.Core
{
    public class Member
    {
        public Guid MemberId { get; set; }
        public Guid TutorId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string BloodType { get; set; } = string.Empty;
        public string Identification { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Belt { get; set; } = string.Empty;
        public decimal MonthlyFee { get; set; }
        public decimal AnualFee { get; set; }
        public decimal TotalAmountDue { get; set; }
    }
}