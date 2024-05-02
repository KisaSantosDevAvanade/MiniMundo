using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiniMundo.Data;
using MiniMundo.Models;

namespace MiniMundo.Controllers
{
    public class CredencialsController : Controller
    {
        private readonly MiniMundoContext _context;

        public CredencialsController(MiniMundoContext context)
        {
            _context = context;
        }

        // GET: Credencials
        public async Task<IActionResult> Index()
        {
            return View(await _context.Credencial.ToListAsync());
        }

        // GET: Credencials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credencial = await _context.Credencial
                .FirstOrDefaultAsync(m => m.CredencialID == id);
            if (credencial == null)
            {
                return NotFound();
            }

            return View(credencial);
        }

        // GET: Credencials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Credencials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CredencialID,NomeAdm,NivelAcesso")] Credencial credencial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(credencial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(credencial);
        }

        // GET: Credencials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credencial = await _context.Credencial.FindAsync(id);
            if (credencial == null)
            {
                return NotFound();
            }
            return View(credencial);
        }

        // POST: Credencials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CredencialID,NomeAdm,NivelAcesso")] Credencial credencial)
        {
            if (id != credencial.CredencialID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(credencial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CredencialExists(credencial.CredencialID))
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
            return View(credencial);
        }

        // GET: Credencials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credencial = await _context.Credencial
                .FirstOrDefaultAsync(m => m.CredencialID == id);
            if (credencial == null)
            {
                return NotFound();
            }

            return View(credencial);
        }

        // POST: Credencials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var credencial = await _context.Credencial.FindAsync(id);
            if (credencial != null)
            {
                _context.Credencial.Remove(credencial);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CredencialExists(int id)
        {
            return _context.Credencial.Any(e => e.CredencialID == id);
        }
    }
}
