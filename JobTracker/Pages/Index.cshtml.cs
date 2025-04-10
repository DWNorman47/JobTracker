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
    public class IndexModel : PageModel
    {
        private readonly JobTracker.Data.ApplicationDbContext _context;

        public IndexModel(JobTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<JobApplication> JobApplication { get;set; } = default!;

        public async Task OnGetAsync()
        {
            JobApplication = await _context.JobApplications.ToListAsync();
        }
    }
}
