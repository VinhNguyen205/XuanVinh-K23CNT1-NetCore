using System.ComponentModel.DataAnnotations;

namespace Lab07Session04.Models
{
    public class NxvMember
    {
        public int NxvId { get; set; }

        public string NxvName { get; set; }
        public string NxvUserName { get; set; }

        public string NxvPassword { get; set; }

        public string NxvEmail { get; set; }

        public bool NxvStatus { get; set; }
    }
}