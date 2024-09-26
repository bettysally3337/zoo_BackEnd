using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyBackend.Data;
using MyBackend.Models;

namespace MyBackend.Controllers
{
    public class PlantsController : Controller
    {
        private readonly ZooDBContext _context;

        public PlantsController(ZooDBContext context)
        {
            _context = context;
        }

        // GET: Plants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Plant.ToListAsync());
        }

        // GET: Plants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plants = await _context.Plant
                .FirstOrDefaultAsync(m => m.idx == id);
            if (plants == null)
            {
                return NotFound();
            }

            return View(plants);
        }

        [HttpGet("/ZonedPlant/{Zone:maxlength(20)=熱帶雨林區}")]
        public async Task<ActionResult<IEnumerable<Plants>>> ZonedPlantAsync(String Zone)
        {
            System.Diagnostics.Debug.WriteLine($"/ZonedPlant/{Zone}");
            // 除錯用
            //await _context.Plants.Where(d => d.E_Name.Contains(Zone)).ForEachAsync(item =>
            //{
            //    System.Diagnostics.Debug.WriteLine($"/ZonedPlant/{Zone}/{item.E_no}");
            //});

            IEnumerable<Plants> query = _context.Plant.Where(d => d.F_Location.Contains(Zone));

            return query == null ? new List<Plants>() : query.ToList();
        }

        // GET: Plants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Plants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idx,F_Name_Ch,F_Summary,F_Keywords,F_AlsoKnown,F_Geo,F_Location,F_Name_En,F_Name_Latin,F_Family,F_Genus,F_Brief,F_Feature,F_Function_Application,F_Code,F_Pic01_ALT,F_Pic01_URL,F_Pic02_ALT,F_Pic02_URL,F_Pic03_ALT,F_Pic03_URL,F_Pic04_ALT,F_Pic04_URL,F_pdf01_ALT,F_pdf01_URL,F_pdf02_ALT,F_pdf02_URL,F_Voice01_ALT,F_Voice01_URL,F_Voice02_ALT,F_Voice02_URL,F_Voice03_ALT,F_Voice03_URL,F_Vedio_URL,F_Update,F_CID")] Plants plants)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plants);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plants);
        }

        // GET: Plants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plants = await _context.Plant.FindAsync(id);
            if (plants == null)
            {
                return NotFound();
            }
            return View(plants);
        }

        // POST: Plants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idx,F_Name_Ch,F_Summary,F_Keywords,F_AlsoKnown,F_Geo,F_Location,F_Name_En,F_Name_Latin,F_Family,F_Genus,F_Brief,F_Feature,F_Function_Application,F_Code,F_Pic01_ALT,F_Pic01_URL,F_Pic02_ALT,F_Pic02_URL,F_Pic03_ALT,F_Pic03_URL,F_Pic04_ALT,F_Pic04_URL,F_pdf01_ALT,F_pdf01_URL,F_pdf02_ALT,F_pdf02_URL,F_Voice01_ALT,F_Voice01_URL,F_Voice02_ALT,F_Voice02_URL,F_Voice03_ALT,F_Voice03_URL,F_Vedio_URL,F_Update,F_CID")] Plants plants)
        {
            if (id != plants.idx)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plants);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlantsExists(plants.idx))
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
            return View(plants);
        }

        // GET: Plants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plants = await _context.Plant
                .FirstOrDefaultAsync(m => m.idx == id);
            if (plants == null)
            {
                return NotFound();
            }

            return View(plants);
        }

        // POST: Plants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plants = await _context.Plant.FindAsync(id);
            if (plants != null)
            {
                _context.Plant.Remove(plants);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlantsExists(int id)
        {
            return _context.Plant.Any(e => e.idx == id);
        }
    }
}
