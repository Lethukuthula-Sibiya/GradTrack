using System.ComponentModel.DataAnnotations;

namespace GradTrack.Models
{
    public class Opportunity
    {
        public int Id { get; set; }

        [Required]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        public string OpportunityName { get; set; } = string.Empty;

        [Required]
        public string OpportunityType { get; set; } = string.Empty;

        public DateTime Deadline { get; set; }

        public string Status { get; set; } = string.Empty;

        public string? Notes { get; set; }
    }
}