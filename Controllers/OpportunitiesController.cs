
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GradTrack.Models;
using GradTrack.Data;

public class OpportunitiesController : Controller
{
    private readonly ApplicationDbContext _context;

    public OpportunitiesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: OPPORTUNITYS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Opportunities.ToListAsync());
    }

    // GET: OPPORTUNITYS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var opportunity = await _context.Opportunities
            .FirstOrDefaultAsync(m => m.Id == id);
        if (opportunity == null)
        {
            return NotFound();
        }

        return View(opportunity);
    }

    // GET: OPPORTUNITYS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: OPPORTUNITYS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,CompanyName,OpportunityName,OpportunityType,Deadline,Status,Notes")] Opportunity opportunity)
    {
        if (ModelState.IsValid)
        {
            _context.Add(opportunity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(opportunity);
    }

    // GET: OPPORTUNITYS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var opportunity = await _context.Opportunities.FindAsync(id);
        if (opportunity == null)
        {
            return NotFound();
        }
        return View(opportunity);
    }

    // POST: OPPORTUNITYS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,CompanyName,OpportunityName,OpportunityType,Deadline,Status,Notes")] Opportunity opportunity)
    {
        if (id != opportunity.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(opportunity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpportunityExists(opportunity.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(opportunity);
    }

    // GET: OPPORTUNITYS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var opportunity = await _context.Opportunities
            .FirstOrDefaultAsync(m => m.Id == id);
        if (opportunity == null)
        {
            return NotFound();
        }

        return View(opportunity);
    }

    // POST: OPPORTUNITYS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var opportunity = await _context.Opportunities.FindAsync(id);
        if (opportunity != null)
        {
            _context.Opportunities.Remove(opportunity);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool OpportunityExists(int? id)
    {
        return _context.Opportunities.Any(e => e.Id == id);
    }
}
