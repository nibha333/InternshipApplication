using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InternshipApplication.Models;
using InternshipApplication.Models.NewFolder1;

namespace InternshipApplication.Controllers
{
    public class MainApplicationController : Controller
    {
        private readonly InternshipApplicationContext _context;

        public MainApplicationController(InternshipApplicationContext context)
        {
            _context = context;    
        }

        // GET: MainApplications
        public async Task<IActionResult> Index()
        {
            return View(await _context.MainApplication.ToListAsync());
        }

        // GET: MainApplications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainApplication = await _context.MainApplication
                .SingleOrDefaultAsync(m => m.MainApplicationID == id);
            if (mainApplication == null)
            {
                return NotFound();
            }

            return View(mainApplication);
        }

        // GET: MainApplications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MainApplications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MainApplicationID,studentFirstName,studentMiddleName,studentLastName,wNum,studentEmail,studentCellPhone,studentWorkPhone,studentPresentAddress,studentPermanentAddress,Degree,Concentration,isPartTime,isSignedByStudentApplication,dateApplicationReceivedByyDept,IsApplicationApprovedByDept,reasonWhyOrWhyNotApplicationIsApprovedByDept,isApplicationFormSignedByInstructor,dataInstructorSignedApplicationForm,IsApplicationSignedByDeptHead,dateApplicationsignedByDeptHead,isApplicationSignedByDean,dateApplicationSignedByDean,isSignedByAcademicAdvisor,dataSignedByAcademicAdvisor,isSignedBySupervisorUponCompletion,dataSupervisorSignedUponCompletion,employersName,employersAddress,supervisorName,supervisorTitle,supervisorEmail,supervisorPhone,employmentBeginDate,employmentEndingDate,jobTitle,jobResponsibilities")] MainApplication mainApplication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mainApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(mainApplication);
        }

        // GET: MainApplications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainApplication = await _context.MainApplication.SingleOrDefaultAsync(m => m.MainApplicationID == id);
            if (mainApplication == null)
            {
                return NotFound();
            }
            return View(mainApplication);
        }

        // POST: MainApplications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MainApplicationID,studentFirstName,studentMiddleName,studentLastName,wNum,studentEmail,studentCellPhone,studentWorkPhone,studentPresentAddress,studentPermanentAddress,Degree,Concentration,isPartTime,isSignedByStudentApplication,dateApplicationReceivedByyDept,IsApplicationApprovedByDept,reasonWhyOrWhyNotApplicationIsApprovedByDept,isApplicationFormSignedByInstructor,dataInstructorSignedApplicationForm,IsApplicationSignedByDeptHead,dateApplicationsignedByDeptHead,isApplicationSignedByDean,dateApplicationSignedByDean,isSignedByAcademicAdvisor,dataSignedByAcademicAdvisor,isSignedBySupervisorUponCompletion,dataSupervisorSignedUponCompletion,employersName,employersAddress,supervisorName,supervisorTitle,supervisorEmail,supervisorPhone,employmentBeginDate,employmentEndingDate,jobTitle,jobResponsibilities")] MainApplication mainApplication)
        {
            if (id != mainApplication.MainApplicationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mainApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MainApplicationExists(mainApplication.MainApplicationID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(mainApplication);
        }

        // GET: MainApplications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainApplication = await _context.MainApplication
                .SingleOrDefaultAsync(m => m.MainApplicationID == id);
            if (mainApplication == null)
            {
                return NotFound();
            }

            return View(mainApplication);
        }

        // POST: MainApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mainApplication = await _context.MainApplication.SingleOrDefaultAsync(m => m.MainApplicationID == id);
            _context.MainApplication.Remove(mainApplication);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool MainApplicationExists(int id)
        {
            return _context.MainApplication.Any(e => e.MainApplicationID == id);
        }
    }
}
