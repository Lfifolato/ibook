using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ibook.Data;
using ibook.Models;

namespace ibook.Controllers
{
    public class EscritoresController : Controller
    {
        private readonly DataContext _context;

        public EscritoresController(DataContext context)
        {
            _context = context;
        }

        // GET: Escritores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Escritores.ToListAsync());
        }

        // GET: Escritores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var escritores = await _context.Escritores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (escritores == null)
            {
                return NotFound();
            }

            return View(escritores);
        }

        // GET: Escritores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Escritores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nome,email,telefone,idade,City")] Escritores escritores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(escritores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(escritores);
        }

        // GET: Escritores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var escritores = await _context.Escritores.FindAsync(id);
            if (escritores == null)
            {
                return NotFound();
            }
            return View(escritores);
        }

        // POST: Escritores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,nome,email,telefone,idade,City")] Escritores escritores)
        {
            if (id != escritores.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(escritores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EscritoresExists(escritores.Id))
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
            return View(escritores);
        }

        // GET: Escritores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var escritores = await _context.Escritores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (escritores == null)
            {
                return NotFound();
            }

            return View(escritores);
        }

        // POST: Escritores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var escritores = await _context.Escritores.FindAsync(id);
            _context.Escritores.Remove(escritores);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EscritoresExists(int id)
        {
            return _context.Escritores.Any(e => e.Id == id);
        }
    }
}
