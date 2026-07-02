using GradTrack.Models;

namespace GradTrack.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalOpportunities { get; set; }

        public int AppliedCount { get; set; }

        public int InterviewCount { get; set; }

        public int OfferCount { get; set; }

        public int RejectedCount { get; set; }

        public List<Opportunity> UpcomingDeadlines { get; set; } = new();
    }
}