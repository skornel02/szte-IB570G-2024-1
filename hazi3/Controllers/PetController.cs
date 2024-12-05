﻿using hazi3.Entities;
using hazi3.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hazi3.Controllers;

public class PetController : Controller
{
    private readonly ApplicationDbContext _context;

    public PetController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Pets
            .Include(_ => _.Category)
            .ToListAsync());
    }

    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        PetEntity? petEntity = await _context.Pets
            .Include(_ => _.Category)
            .FirstOrDefaultAsync(m => m.Id == id);
        return petEntity == null ? NotFound() : View(petEntity);
    }

    public async Task<IActionResult> Create()
    {
        var categories = await _context.Categories.ToListAsync();
        ViewBag.Categories = categories;

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Name,Gender,Age,Weight,PhotoUrl,CategoryId")] PetEntity petEntity)
    {
        ModelState.Remove(nameof(PetEntity.Category));

        if (ModelState.IsValid)
        {
            _context.Add(petEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(petEntity);
    }

    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var categories = await _context.Categories.ToListAsync();
        ViewBag.Categories = categories;

        PetEntity ? petEntity = await _context.Pets.FindAsync(id);
        return petEntity == null ? NotFound() : View(petEntity);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Gender,Age,Weight,PhotoUrl,CategoryId")] PetEntity petEntity)
    {
        if (id != petEntity.Id)
        {
            return NotFound();
        }

        ModelState.Remove(nameof(PetEntity.Category));

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(petEntity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetEntityExists(petEntity.Id))
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
        return View(petEntity);
    }

    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        PetEntity? petEntity = await _context.Pets
            .FirstOrDefaultAsync(m => m.Id == id);
        return petEntity == null ? NotFound() : View(petEntity);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        PetEntity? petEntity = await _context.Pets.FindAsync(id);
        if (petEntity != null)
        {
            _context.Pets.Remove(petEntity);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PetEntityExists(long id)
    {
        return _context.Pets.Any(e => e.Id == id);
    }
}
