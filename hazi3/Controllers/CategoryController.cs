using hazi3.Entities;
using hazi3.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hazi3.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _context;

    public CategoryController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Categories.ToListAsync());
    }

    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        CategoryEntity? categoryEntity = await _context.Categories
            .FirstOrDefaultAsync(m => m.Id == id);
        return categoryEntity == null ? NotFound() : View(categoryEntity);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Name,Description")] CategoryEntity categoryEntity)
    {
        ModelState.Remove(nameof(CategoryEntity.Pets));

        if (ModelState.IsValid)
        {
            _context.Add(categoryEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(categoryEntity);
    }

    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        CategoryEntity? categoryEntity = await _context.Categories.FindAsync(id);
        return categoryEntity == null ? NotFound() : View(categoryEntity);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long id, [Bind("Name,Description")] CategoryEntity categoryEntity)
    {
        if (id != categoryEntity.Id)
        {
            return NotFound();
        }

        ModelState.Remove(nameof(CategoryEntity.Pets));

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(categoryEntity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryEntityExists(categoryEntity.Id))
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
        return View(categoryEntity);
    }

    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        CategoryEntity? categoryEntity = await _context.Categories
            .FirstOrDefaultAsync(m => m.Id == id);
        return categoryEntity == null ? NotFound() : View(categoryEntity);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        CategoryEntity? categoryEntity = await _context.Categories.FindAsync(id);
        if (categoryEntity != null)
        {
            _context.Categories.Remove(categoryEntity);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool CategoryEntityExists(long id)
    {
        return _context.Categories.Any(e => e.Id == id);
    }
}
