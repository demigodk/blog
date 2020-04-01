using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using principlesformen.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace principlesformen.Pages.Admin.Post
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly PrinciplesDbContext _context;

        public CreateModel(PrinciplesDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {           
            public string UserId { get; set; }
            public string Title { get; set; }
            public int CategoryId { get; set; }
            public int? TagId { get; set; }
            public string Summary { get; set; }
            public string FullBody { get; set; }
            public List<IFormFile> BannerImagePath { get; set; }
            public byte[] SecondImagePath { get; set; }
            public byte[] ThirdImagePath { get; set; }
            public int? NumLikes { get; set; }
            public DateTime? DatePublished { get; set; }
            public bool CommentsEnabled { get; set; }
            public int? NumViews { get; set; }
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryId"] = new SelectList(_context.TblCategory, "CategoryId", "Category");
            ViewData["TagId"] = new SelectList(_context.TblTag, "TagId", "Tag");
            ViewData["UserId"] = new SelectList(_context.TblUser, "UserId", "UserId");
            return Page();
        }

        [BindProperty]
        public TblPost TblPost { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TblPost post = new TblPost();

            if (Input.BannerImagePath != null && Input.BannerImagePath.Count > 0)
            {
                foreach(var item in Input.BannerImagePath)
                {
                    using (var stream = new MemoryStream())
                    {
                        await item.CopyToAsync(stream);
                        post.BannerImagePath = stream.ToArray();
                    }
                }
            }

            post.UserId = Input.UserId;
            post.Title = Input.Title;
            post.CategoryId = Input.CategoryId;
            post.Summary = Input.Summary;
            post.FullBody = Input.FullBody;
            post.NumViews = 0;
            post.DatePublished = DateTime.Today;


            _context.TblPost.Add(post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
