using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class JobApplication
    {
        public int Id { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Position { get; set; }

        public string Status { get; set; } // e.g., Applied, Interviewed, Offer, Rejected

        [DataType(DataType.Date)]
        public DateTime AppliedDate { get; set; }
    }
}
