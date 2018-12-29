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
    public class SubjectGradesController : Controller
    {
        private readonly StudentManagerContext _context;

        public SubjectGradesController(StudentManagerContext context)
        {
            _context = context;
        }

        // GET: SubjectGrades
        public async Task<IActionResult> Index()
        {
            var studentManagerContext = _context.SubjectGrade.Include(s => s.Grade).Include(s => s.Subject);
            return View(await studentManagerContext.ToListAsync());
        }

        // GET: SubjectGrades/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subjectGrade = await _context.SubjectGrade
                .Include(s => s.Grade)
                .Include(s => s.Subject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subjectGrade == null)
            {
                return NotFound();
            }

            return View(subjectGrade);
        }

        // GET: SubjectGrades/Create
        public IActionResult Create()
        {
            ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "GradeName");
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name");
            return View();
        }

        // POST: SubjectGrades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SubjectId,GradeId,StartTime,EndTime")] SubjectGrade subjectGrade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subjectGrade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "Id", subjectGrade.GradeId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", subjectGrade.SubjectId);
            return View(subjectGrade);
        }

        // GET: SubjectGrades/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subjectGrade = await _context.SubjectGrade.FindAsync(id);
            if (subjectGrade == null)
            {
                return NotFound();
            }
            ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "Id", subjectGrade.GradeId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", subjectGrade.SubjectId);
            return View(subjectGrade);
        }

        // POST: SubjectGrades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,SubjectId,GradeId,StartTime,EndTime")] SubjectGrade subjectGrade)
        {
            if (id != subjectGrade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subjectGrade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubjectGradeExists(subjectGrade.Id))
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
            ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "Id", subjectGrade.GradeId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Name", subjectGrade.SubjectId);
            return View(subjectGrade);
        }

        // GET: SubjectGrades/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subjectGrade = await _context.SubjectGrade
                .Include(s => s.Grade)
                .Include(s => s.Subject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subjectGrade == null)
            {
                return NotFound();
            }

            return View(subjectGrade);
        }

        // POST: SubjectGrades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var subjectGrade = await _context.SubjectGrade.FindAsync(id);
            _context.SubjectGrade.Remove(subjectGrade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubjectGradeExists(long id)
        {
            return _context.SubjectGrade.Any(e => e.Id == id);
        }
    }
}
