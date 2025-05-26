using System.ComponentModel.DataAnnotations;

namespace NxvLab06.Models
{
    public class NxvEmployee
    {
        public int NxvId { get; set; }
        [Required]
        public string? NxvName { get; set; }
        [Required]
        public DateTime NxvBirthDay { get; set; }
        [Required, EmailAddress]
        public string? NxvEmail { get; set; }
        [Required]
        public string? NxvPhone { get; set; }
        [Required]
        public decimal NxvSalary { get; set; }
        public bool NxvStatus { get; set; }
    }
}
