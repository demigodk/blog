using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using principlesformen.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace principlesformen.Pages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PrinciplesDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, PrinciplesDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<TblPost> posts { get; set; }

        //[BindProperty]
        public List<InputModel> Inputs { get; set; }

        public class InputModel
        {
            public int PostId { get; set; }
            public string UserId { get; set; }
            public string Title { get; set; }
            public int CategoryId { get; set; }
            public string Category { get; set; }
            public int? TagId { get; set; }
            public string Summary { get; set; }
            public string imageDataUrl { get; set; }
            public string FullBody { get; set; }
            public byte[] BannerImagePath { get; set; }
            public byte[] SecondImagePath { get; set; }
            public byte[] ThirdImagePath { get; set; }
            public int? NumLikes { get; set; }
            public DateTime? DatePublished { get; set; }
            public bool CommentsEnabled { get; set; }
            public int? NumViews { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            posts = await _context.TblPost
                .Include(t => t.Category).ToListAsync();

            Inputs = new List<InputModel>();

            foreach (var item in posts)
            {

                //byte[] imageByteData = _context.TblPost.FirstOrDefault(m => m.PostId == item.PostId).BannerImagePath;
                string imageBase64Data = Convert.ToBase64String(_context.TblPost.FirstOrDefault(m => m.PostId == item.PostId).BannerImagePath);
                string imageDataUrl = String.Format("data:image/png;base64, {0}", imageBase64Data);

                InputModel model = new InputModel
                {
                     PostId = item.PostId,
                     UserId = item.UserId,
                     Title = item.Title,
                     CategoryId = item.CategoryId,
                     Category = item.Category.Category,
                     TagId = item.TagId,
                     Summary = item.Summary,
                     imageDataUrl = imageDataUrl,
                     FullBody = item.FullBody,
                     BannerImagePath = item.BannerImagePath,
                     SecondImagePath = item.SecondImagePath,
                     ThirdImagePath = item.ThirdImagePath,
                     NumLikes = item.NumLikes,
                     DatePublished = item.DatePublished,
                     CommentsEnabled = item.CommentsEnabled,
                     NumViews = item.NumViews
                };


                //byte[] imageByteData = _context.TblPost.FirstOrDefault(m => m.PostId == item.PostId).BannerImagePath;
                //string imageBase64Data = Convert.ToBase64String(imageByteData);
                //string imageDataUrl = String.Format("data:image/png;base64, {0}", imageBase64Data);

                Inputs.Add(model);
            }

            return Page();
        }
    }
}
