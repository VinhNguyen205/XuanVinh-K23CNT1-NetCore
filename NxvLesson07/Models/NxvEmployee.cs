using System.ComponentModel.DataAnnotations;

namespace NxvLesson07.Models
{
    public class NxvEmployee
    {
        public int NxvId { get; set; }
        public string NxvName { get; set; }
        public DateTime NxvBirthDay { get; set; }
        public string NxvEmail { get; set; }
        public string NxvPhone { get; set; }
        public decimal NxvSalary { get; set; }
        public bool NxvStatus { get; set; }
    }
}
