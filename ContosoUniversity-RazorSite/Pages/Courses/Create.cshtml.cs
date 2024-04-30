using ContosoUniversity_RazorSite.Data;
using ContosoUniversity_RazorSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoUniversity_RazorSite.Pages.Courses
{
    public class CreateModel : PageModel
    {
        private readonly SchoolContext _context;

        public CreateModel(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           await _context.Courses.AddAsync(Course);
           await _context.SaveChangesAsync();
            return RedirectToPage("./Index");

           

        }
    }
}
