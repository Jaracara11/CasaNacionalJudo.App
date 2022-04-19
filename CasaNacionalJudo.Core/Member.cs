using System.ComponentModel.DataAnnotations;

namespace CasaNacionalJudo.Core
{
    public class Member
    {
        public int MemberId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? BirthDate { get; set; }
        public string? BloodType { get; set; }
        public string? Identification { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string? Belt { get; set; } 
        public string? SignUpDate { get; set; }
        public decimal MonthlyFee { get; set; }
        public decimal AnualFee { get; set; }
        public decimal TotalAmountDue { get; set; }
    }
}