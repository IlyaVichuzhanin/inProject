using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using inProject;
using inProject.Models;
using inProject.Models.ViewModels;
using inProject.Models.Domain;

namespace inProject.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly AppDbContext _context;

        public CompaniesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
             return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddCompanyRequest addCompanyRequest)
        {
            var company = new Company 
            { 
                CompanyName = addCompanyRequest.CompanyName 
            };
            _context.Companies.Add(company);
            _context.SaveChanges();
            return View("Add");
        }




        //// GET: Companies/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Companies == null)
        //    {
        //        return NotFound();
        //    }

        //    var company = await _context.Companies
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(company);
        //}

        //// GET: Companies/AddOrEdit
        //// GET: Companies/AddOrEdit/5

        //public async Task<IActionResult> AddOrEdit(int id=0)
        //{
        //    if(id==0)
        //        return View();
        //    else
        //    {
        //        var company = await _context.Companies.FindAsync(id);
        //        if (company == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(company);
        //    }
        //}

        //// POST: Companies/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        ////[HttpPost]
        ////[ValidateAntiForgeryToken]
        ////public async Task<IActionResult> Create([Bind("Id,CompanyName")] Company company)
        ////{
        ////    if (ModelState.IsValid)
        ////    {
        ////        _context.Add(company);
        ////        await _context.SaveChangesAsync();
        ////        return RedirectToAction(nameof(Index));
        ////    }
        ////    return View(company);
        ////}

        //// GET: Companies/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Companies == null)
        //    {
        //        return NotFound();
        //    }

        //    var company = await _context.Companies.FindAsync(id);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(company);
        //}

        //// POST: Companies/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        ////[HttpPost]
        ////[ValidateAntiForgeryToken]
        ////public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyName")] Company company)
        ////{
        ////    if (id != company.Id)
        ////    {
        ////        return NotFound();
        ////    }

        ////    if (ModelState.IsValid)
        ////    {
        ////        try
        ////        {
        ////            _context.Update(company);
        ////            await _context.SaveChangesAsync();
        ////        }
        ////        catch (DbUpdateConcurrencyException)
        ////        {
        ////            if (!CompanyExists(company.Id))
        ////            {
        ////                return NotFound();
        ////            }
        ////            else
        ////            {
        ////                throw;
        ////            }
        ////        }
        ////        return RedirectToAction(nameof(Index));
        ////    }
        ////    return View(company);
        ////}

        //// GET: Companies/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Companies == null)
        //    {
        //        return NotFound();
        //    }

        //    var company = await _context.Companies
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(company);
        //}

        //// POST: Companies/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Companies == null)
        //    {
        //        return Problem("Entity set 'AppDbContext.Companies'  is null.");
        //    }
        //    var company = await _context.Companies.FindAsync(id);
        //    if (company != null)
        //    {
        //        _context.Companies.Remove(company);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CompanyExists(int id)
        //{
        //  return (_context.Companies?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
