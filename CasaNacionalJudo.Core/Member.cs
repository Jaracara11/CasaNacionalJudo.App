using System.ComponentModel.DataAnnotations;

namespace CasaNacionalJudo.Core
{
    public class Member
    {
        public int MemberId { get; set; }
        public int TutorId { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime BirthDate { get; set; }
        public string BloodType { get; set; } = string.Empty;
        public string Identification { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        public string Belt { get; set; } = string.Empty;
        public decimal MonthlyFee { get; set; }
        public decimal AnualFee { get; set; }
        public decimal TotalAmountDue { get; set; }
    }
}