using GradTrack.Data;
using GradTrack.Models;
using GradTrack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GradTrack.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var dashboard = new DashboardViewModel
            {
                TotalOpportunities = _context.Opportunities.Count(),

                AppliedCount = _context.Opportunities.Count(o => o.Status == "Applied"),

                InterviewCount = _context.Opportunities.Count(o => o.Status == "Interview"),

                OfferCount = _context.Opportunities.Count(o => o.Status == "Offer"),

                RejectedCount = _context.Opportunities.Count(o => o.Status == "Rejected"),

                UpcomingDeadlines = _context.Opportunities.Where(o => o.Deadline >= DateTime.Today).OrderBy(o => o.Deadline).Take(5).ToList(),

                OverdueOpportunities = _context.Opportunities.Where(o => o.Deadline < DateTime.Today).OrderByDescending(o => o.Deadline).ToList()
            };

            return View(dashboard);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
