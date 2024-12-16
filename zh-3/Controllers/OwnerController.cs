using hazi3.Entities;
using hazi3.Enums;
using hazi3.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hazi3.Controllers;

public class OwnerController : Controller
{
    private readonly ApplicationDbContext _context;

    public OwnerController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Owner
    public async Task<IActionResult> Index(
        string sortBy = "Id",
        string sortOrder = "Asc",
        string? searchByName = null,
        HomeType? homeTypeFilter = null,
        bool? experiencedFilter = null)
    {
        var query = _context.OwnerEntity.AsQueryable();

        query = (sortBy, sortOrder) switch
        {
            ("Id", "Asc") => query.OrderBy(_ => _.Id),
            ("Id", _) => query.OrderByDescending(_ => _.Id),
            ("Name", "Asc") => query.OrderBy(_ => _.Name),
            _ => query.OrderByDescending(_ => _.Name)
        };

        if (!string.IsNullOrEmpty(searchByName))
        {
            query = query.Where(_ => _.Name.Contains(searchByName));
        }

        if (homeTypeFilter is not null)
        {
            query = query.Where(_ => _.HomeType == homeTypeFilter);
        }

        if (experiencedFilter is not null)
        {
            query = query.Where(_ => _.ExperiencedKeeper == experiencedFilter);
        }

        return View(await query.ToListAsync());
    }

    // GET: Owner/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pets = await _context.Pets
            .Where(_ => _.OwnerId == id)
            .ToListAsync();

        ViewBag.Pets = pets;

        OwnerEntity? ownerEntity = await _context.OwnerEntity
            .FirstOrDefaultAsync(m => m.Id == id);
        return ownerEntity == null ? NotFound() : View(ownerEntity);
    }

    // GET: Owner/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Owner/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,PhoneNumber,HomeType,ExperiencedKeeper")] OwnerEntity ownerEntity)
    {
        ModelState.Remove(nameof(OwnerEntity.Pets));

        if (ModelState.IsValid)
        {
            _ = _context.Add(ownerEntity);
            _ = await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ownerEntity);
    }

    // GET: Owner/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        OwnerEntity? ownerEntity = await _context.OwnerEntity.FindAsync(id);
        return ownerEntity == null ? NotFound() : View(ownerEntity);
    }

    // POST: Owner/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long id, [Bind("Id,Name,PhoneNumber,HomeType,ExperiencedKeeper")] OwnerEntity ownerEntity)
    {
        if (id != ownerEntity.Id)
        {
            return NotFound();
        }

        ModelState.Remove(nameof(OwnerEntity.Pets));
        
        if (ModelState.IsValid)
        {
            try
            {
                _ = _context.Update(ownerEntity);
                _ = await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OwnerEntityExists(ownerEntity.Id))
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
        return View(ownerEntity);
    }

    // GET: Owner/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        OwnerEntity? ownerEntity = await _context.OwnerEntity
            .FirstOrDefaultAsync(m => m.Id == id);
        return ownerEntity == null ? NotFound() : View(ownerEntity);
    }

    // POST: Owner/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        OwnerEntity? ownerEntity = await _context.OwnerEntity.FindAsync(id);
        if (ownerEntity != null)
        {
            _ = _context.OwnerEntity.Remove(ownerEntity);
        }

        _ = await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool OwnerEntityExists(long id)
    {
        return _context.OwnerEntity.Any(e => e.Id == id);
    }
}
