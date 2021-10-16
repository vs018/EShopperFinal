using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EShopper.Data;
using EShopper.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;

namespace EShopper.Controllers
{
        public class VegetablesController : Controller
        {
            private readonly EShopperContext _context;

            public VegetablesController(EShopperContext context)
            {
                _context = context;
            }

            // GET: Vegetables
            public async Task<IActionResult> Index()
            {
                
                    return View(await _context.Vegetables.ToListAsync());
            }

        
            // GET: Vegetables/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var Vegetables = await _context.Vegetables
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (Vegetables == null)
                {
                    return NotFound();
                }

                return View(Vegetables);
            }

            // GET: Vegetables/Create
            public IActionResult Create()
            {
                return View();
            }

            // POST: Vegetables/Create
            // To protect from overposting attacks, enable the specific properties you want to bind to, for 
            // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("Id,Name,Type,Price")] Vegetables Vegetables)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(Vegetables);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(Vegetables);
            }

            // GET: Vegetables/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var Vegetables = await _context.Vegetables.FindAsync(id);
                if (Vegetables == null)
                {
                    return NotFound();
                }
                return View(Vegetables);
            }

            // POST: Vegetables/Edit/5
            // To protect from overposting attacks, enable the specific properties you want to bind to, for 
            // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,Price")] Vegetables Vegetables)
            {
                if (id != Vegetables.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(Vegetables);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!VegetablesExists(Vegetables.Id))
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
                return View(Vegetables);
            }

            // GET: Vegetables/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var Vegetables = await _context.Vegetables
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (Vegetables == null)
                {
                    return NotFound();
                }

                return View(Vegetables);
            }

            // POST: Vegetables/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var Vegetables = await _context.Vegetables.FindAsync(id);
                _context.Vegetables.Remove(Vegetables);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool VegetablesExists(int id)
            {
                return _context.Vegetables.Any(e => e.Id == id);
            }
        }
    }