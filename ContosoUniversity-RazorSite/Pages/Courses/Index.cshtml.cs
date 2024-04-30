using ContosoUniversity_RazorSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity_RazorSite.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversity_RazorSite.Data.SchoolContext _context;

        public IndexModel(ContosoUniversity_RazorSite.Data.SchoolContext context)
        {
            _context = context;
        }

        public List<Course> Course { get; set; }
        public async Task OnGetAsync()
        {
            Course = await _context.Courses.ToListAsync();
        }
    }
}
