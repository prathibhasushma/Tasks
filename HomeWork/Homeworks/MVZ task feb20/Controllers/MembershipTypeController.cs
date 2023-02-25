using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KoreMvc.Data;
using MVZ_task_feb20.Models;

namespace MVZ_task_feb20.Controllers
{
    public class MembershipTypeController : Controller
    {
        private readonly KoreMvcContext _context;

        public MembershipTypeController(KoreMvcContext context)
        {
            _context = context;
        }

        // GET: MembershipType
        public async Task<IActionResult> Index()
        {
            return View(await _context.MembershipTypes.ToListAsync());
        }

        // GET: MembershipType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MembershipTypes == null)
            {
                return NotFound();
            }

            var membershipTypes = await _context.MembershipTypes
                .FirstOrDefaultAsync(m => m.MembershipTypeId == id);
            if (membershipTypes == null)
            {
                return NotFound();
            }

            return View(membershipTypes);
        }

        // GET: MembershipType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MembershipType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MembershipTypeName,MembershipTypeId")] MembershipTypes membershipTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(membershipTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(membershipTypes);
        }

        // GET: MembershipType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MembershipTypes == null)
            {
                return NotFound();
            }

            var membershipTypes = await _context.MembershipTypes.FindAsync(id);
            if (membershipTypes == null)
            {
                return NotFound();
            }
            return View(membershipTypes);
        }

        // POST: MembershipType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MembershipTypeName,MembershipTypeId")] MembershipTypes membershipTypes)
        {
            if (id != membershipTypes.MembershipTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membershipTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembershipTypesExists(membershipTypes.MembershipTypeId))
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
            return View(membershipTypes);
        }

        // GET: MembershipType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MembershipTypes == null)
            {
                return NotFound();
            }

            var membershipTypes = await _context.MembershipTypes
                .FirstOrDefaultAsync(m => m.MembershipTypeId == id);
            if (membershipTypes == null)
            {
                return NotFound();
            }

            return View(membershipTypes);
        }

        // POST: MembershipType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MembershipTypes == null)
            {
                return Problem("Entity set 'KoreMvcContext.MembershipTypes'  is null.");
            }
            var membershipTypes = await _context.MembershipTypes.FindAsync(id);
            if (membershipTypes != null)
            {
                _context.MembershipTypes.Remove(membershipTypes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MembershipTypesExists(int id)
        {
            return _context.MembershipTypes.Any(e => e.MembershipTypeId == id);
        }
    }
}
