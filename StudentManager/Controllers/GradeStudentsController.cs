using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManager.Models;

namespace StudentManager.Controllers
{
    public class GradeStudentsController : Controller
    {
        private readonly StudentManagerContext _context;

        public GradeStudentsController(StudentManagerContext context)
        {
            _context = context;
        }

        // GET: GradeStudents
        public async Task<IActionResult> Index()
        {
            var studentManagerContext = _context.GradeStudent.Include(g => g.Account).Include(g => g.Grade);
            return View(await studentManagerContext.ToListAsync());
        }

        // GET: GradeStudents/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradeStudent = await _context.GradeStudent
                .Include(g => g.Account)
                .Include(g => g.Grade)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gradeStudent == null)
            {
                return NotFound();
            }

            return View(gradeStudent);
        }

        // GET: GradeStudents/Create
        public IActionResult Create()
        {
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Email");
            ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "GradeName");
            return View();
        }

        // POST: GradeStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GradeId,AccountId,JoinAt")] GradeStudent gradeStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gradeStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Email", gradeStudent.AccountId);
            ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "Id", gradeStudent.GradeId);
            return View(gradeStudent);
        }

        // GET: GradeStudents/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradeStudent = await _context.GradeStudent.FindAsync(id);
            if (gradeStudent == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Email", gradeStudent.AccountId);
            ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "Id", gradeStudent.GradeId);
            return View(gradeStudent);
        }

        // POST: GradeStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,GradeId,AccountId,JoinAt")] GradeStudent gradeStudent)
        {
            if (id != gradeStudent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gradeStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GradeStudentExists(gradeStudent.Id))
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
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Email", gradeStudent.AccountId);
            ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "Id", gradeStudent.GradeId);
            return View(gradeStudent);
        }

        // GET: GradeStudents/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradeStudent = await _context.GradeStudent
                .Include(g => g.Account)
                .Include(g => g.Grade)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gradeStudent == null)
            {
                return NotFound();
            }

            return View(gradeStudent);
        }

        // POST: GradeStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var gradeStudent = await _context.GradeStudent.FindAsync(id);
            _context.GradeStudent.Remove(gradeStudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GradeStudentExists(long id)
        {
            return _context.GradeStudent.Any(e => e.Id == id);
        }
    }
}
