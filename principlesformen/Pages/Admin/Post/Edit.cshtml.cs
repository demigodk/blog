using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using principlesformen.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace principlesformen.Pages.Admin.Post
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly PrinciplesDbContext _context;

        public EditModel(PrinciplesDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["CategoryId"] = new SelectList(_context.TblCategory, "CategoryId", "Category");
           ViewData["TagId"] = new SelectList(_context.TblTag, "TagId", "Tag");
           ViewData["UserId"] = new SelectList(_context.TblUser, "UserId", "UserId");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TblPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPostExists(TblPost.PostId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TblPostExists(int id)
        {
            return _context.TblPost.Any(e => e.PostId == id);
        }
    }
}
