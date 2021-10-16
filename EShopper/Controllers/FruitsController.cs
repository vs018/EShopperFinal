using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EShopper.Data;
using EShopper.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EShopper.Controllers
{
    namespace EShopper.Controllers
    {
        public class FruitsController : Controller
        {
            private readonly EShopperContext _context;

            public FruitsController(EShopperContext context)
            {
                _context = context;
            }

            // GET: Fruits
            public async Task<IActionResult> Index()
            {
                return View(await _context.Fruits.ToListAsync());
            }

            // GET: Fruits/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var Fruits = await _context.Fruits
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (Fruits == null)
                {
                    return NotFound();
                }

                return View(Fruits);
            }

            public IActionResult Display()
            {
                return View();
            }

            // GET: Fruits/Create
            public IActionResult Create()
            {
                return View();
            }
            
            // POST: Fruits/Create
            // To protect from overposting attacks, enable the specific properties you want to bind to, for 
            // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("Id,Name,Type,DeliveryAddress")] Fruits Fruits)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(Fruits);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Display));
                }
                return View(Fruits);
            }

            // GET: Fruits/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var Fruits = await _context.Fruits.FindAsync(id);
                if (Fruits == null)
                {
                    return NotFound();
                }
                return View(Fruits);
            }

            // POST: Fruits/Edit/5
            // To protect from overposting attacks, enable the specific properties you want to bind to, for 
            // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,DeliveryAddress")] Fruits Fruits)
            {
                if (id != Fruits.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(Fruits);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!FruitsExists(Fruits.Id))
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
                return View(Fruits);
            }

            // GET: Fruits/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var Fruits = await _context.Fruits
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (Fruits == null)
                {
                    return NotFound();
                }

                return View(Fruits);
            }

            // POST: Fruits/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var Fruits = await _context.Fruits.FindAsync(id);
                _context.Fruits.Remove(Fruits);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool FruitsExists(int id)
            {
                return _context.Fruits.Any(e => e.Id == id);
            }
        }
    }
}
