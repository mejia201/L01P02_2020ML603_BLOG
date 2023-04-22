﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using L01P02_2020ML603_BLOG.Models;

namespace L01P02_2020ML603_BLOG.Controllers
{
    public class comentariosController : Controller
    {
        private readonly blog_DbContext _context;

        public comentariosController(blog_DbContext context)
        {
            _context = context;
        }

        // GET: comentarios
        public async Task<IActionResult> Index()
        {
              return _context.comentarios != null ? 
                          View(await _context.comentarios.ToListAsync()) :
                          Problem("Entity set 'blog_DbContext.comentarios'  is null.");
        }

        // GET: comentarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.comentarios == null)
            {
                return NotFound();
            }

            var comentarios = await _context.comentarios
                .FirstOrDefaultAsync(m => m.cometarioId == id);
            if (comentarios == null)
            {
                return NotFound();
            }

            return View(comentarios);
        }

        // GET: comentarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: comentarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cometarioId,publicacionId,comentario,usuarioId")] comentarios comentarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comentarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comentarios);
        }

        // GET: comentarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.comentarios == null)
            {
                return NotFound();
            }

            var comentarios = await _context.comentarios.FindAsync(id);
            if (comentarios == null)
            {
                return NotFound();
            }
            return View(comentarios);
        }

        // POST: comentarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("cometarioId,publicacionId,comentario,usuarioId")] comentarios comentarios)
        {
            if (id != comentarios.cometarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comentarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!comentariosExists(comentarios.cometarioId))
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
            return View(comentarios);
        }

        // GET: comentarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.comentarios == null)
            {
                return NotFound();
            }

            var comentarios = await _context.comentarios
                .FirstOrDefaultAsync(m => m.cometarioId == id);
            if (comentarios == null)
            {
                return NotFound();
            }

            return View(comentarios);
        }

        // POST: comentarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.comentarios == null)
            {
                return Problem("Entity set 'blog_DbContext.comentarios'  is null.");
            }
            var comentarios = await _context.comentarios.FindAsync(id);
            if (comentarios != null)
            {
                _context.comentarios.Remove(comentarios);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool comentariosExists(int id)
        {
          return (_context.comentarios?.Any(e => e.cometarioId == id)).GetValueOrDefault();
        }
    }
}
