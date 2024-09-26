using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using zoo_backend_vs.Data;
using zoo_backend_vs.Models;

namespace zoo_backend_vs.Controllers
{
    public class AreasController : Controller
    {
        private readonly ZooDBContext _context;

        public AreasController(ZooDBContext context)
        {
            _context = context;
        }

        // GET: Areas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Area.ToListAsync());
        }

        // GET: Areas/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var area = await _context.Area
                .FirstOrDefaultAsync(m => m.E_no == id);
            if (area == null)
            {
                return NotFound();
            }

            return View(area);
        }

        [HttpGet("/ZonedArea/{Zone:maxlength(20)=大貓熊}")]
        public async Task<ActionResult<IEnumerable<Area>>> ZonedAreaAsync(String Zone)
        {
            System.Diagnostics.Debug.WriteLine($"/ZonedArea/{Zone}");
            // 除錯用
            //await _context.Area.Where(d => d.E_Name.Contains(Zone)).ForEachAsync(item =>
            //{
            //    System.Diagnostics.Debug.WriteLine($"/ZonedArea/{Zone}/{item.E_no}");
            //});

            IEnumerable<Area> query = _context.Area.Where(d => d.E_Name.Contains(Zone));

            return query == null ? new List<Area>() : query.ToList();
        }

        // GET: Areas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Areas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("E_no,E_Category,E_Name,E_Pic_URL,E_Info,E_Memo,E_Geo,E_URL")] Area area)
        {
            if (ModelState.IsValid)
            {
                _context.Add(area);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(area);
        }

        // GET: Areas/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var area = await _context.Area.FindAsync(id);
            if (area == null)
            {
                return NotFound();
            }
            return View(area);
        }

        // POST: Areas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("E_no,E_Category,E_Name,E_Pic_URL,E_Info,E_Memo,E_Geo,E_URL")] Area area)
        {
            if (id != area.E_no)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(area);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AreaExists(area.E_no))
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
            return View(area);
        }

        // GET: Areas/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var area = await _context.Area
                .FirstOrDefaultAsync(m => m.E_no == id);
            if (area == null)
            {
                return NotFound();
            }

            return View(area);
        }

        // POST: Areas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var area = await _context.Area.FindAsync(id);
            if (area != null)
            {
                _context.Area.Remove(area);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AreaExists(string id)
        {
            return _context.Area.Any(e => e.E_no == id);
        }
    }
}
