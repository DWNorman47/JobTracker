using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JobTracker.Data;
using JobTracker.Models;

namespace JobTracker.Pages
{
    public class CreateModel : PageModel
    {
        private readonly JobTracker.Data.ApplicationDbContext _context;

        public CreateModel(JobTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JobApplication JobApplication { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.JobApplications.Add(JobApplication);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
