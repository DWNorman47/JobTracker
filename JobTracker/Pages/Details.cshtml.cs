using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JobTracker.Data;
using JobTracker.Models;

namespace JobTracker.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly JobTracker.Data.ApplicationDbContext _context;

        public DetailsModel(JobTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public JobApplication JobApplication { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobapplication = await _context.JobApplications.FirstOrDefaultAsync(m => m.Id == id);
            if (jobapplication == null)
            {
                return NotFound();
            }
            else
            {
                JobApplication = jobapplication;
            }
            return Page();
        }
    }
}
