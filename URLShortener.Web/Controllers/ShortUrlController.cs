#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using URLShortener.Web.Data;
using URLShortener.Web.Models;

namespace URLShortener.Web.Controllers
{
    public class ShortUrlController : Controller
    {
        private readonly URLShortenerContext _context;

        public ShortUrlController(URLShortenerContext context)
        {
            _context = context;
        }

        // GET: ShortUrlModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShortUrlModel.ToListAsync());
        }

        // GET: ShortUrlModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortUrlModel = await _context.ShortUrlModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shortUrlModel == null)
            {
                return NotFound();
            }

            return View(shortUrlModel);
        }

        // GET: ShortUrlModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShortUrlModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Original,Short")] ShortUrlModel shortUrlModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shortUrlModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shortUrlModel);
        }

        // GET: ShortUrlModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortUrlModel = await _context.ShortUrlModel.FindAsync(id);
            if (shortUrlModel == null)
            {
                return NotFound();
            }
            return View(shortUrlModel);
        }

        // POST: ShortUrlModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Original,Short")] ShortUrlModel shortUrlModel)
        {
            if (id != shortUrlModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shortUrlModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShortUrlModelExists(shortUrlModel.Id))
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
            return View(shortUrlModel);
        }

        // GET: ShortUrlModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortUrlModel = await _context.ShortUrlModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shortUrlModel == null)
            {
                return NotFound();
            }

            return View(shortUrlModel);
        }

        // POST: ShortUrlModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shortUrlModel = await _context.ShortUrlModel.FindAsync(id);
            _context.ShortUrlModel.Remove(shortUrlModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShortUrlModelExists(int id)
        {
            return _context.ShortUrlModel.Any(e => e.Id == id);
        }
    }
}
