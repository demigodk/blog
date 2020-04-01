using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using principlesformen.Data.Entities;
using System.Threading.Tasks;

namespace principlesformen.Pages.Admin.Post
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly PrinciplesDbContext _context;

        public DetailsModel(PrinciplesDbContext context)
        {
            _context = context;
        }

        public TblPost TblPost { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblPost = await _context.TblPost
                .Include(t => t.Category)
                .Include(t => t.Tag)
                .Include(t => t.User).FirstOrDefaultAsync(m => m.PostId == id);

            if (TblPost == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
