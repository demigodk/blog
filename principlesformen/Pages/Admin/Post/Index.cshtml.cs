using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using principlesformen.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace principlesformen.Pages.Admin.Post
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly PrinciplesDbContext _context;

        public IndexModel(PrinciplesDbContext context)
        {
            _context = context;
        }

        public IList<TblPost> TblPost { get;set; }

        public async Task OnGetAsync()
        {
            TblPost = await _context.TblPost
                .Include(t => t.Category)
                .Include(t => t.Tag)
                .Include(t => t.User).ToListAsync();

            //foreach (var item in TblPost)
            //{

            //}

            byte[] imageByteData = _context.TblPost.FirstOrDefault().BannerImagePath;           
            string imageBase64Data = Convert.ToBase64String(imageByteData);
           string imageDataUrl = String.Format("data:image/png;base64, {0}", imageBase64Data);
           ViewData["ImageData"] = imageDataUrl;           
        }
    }
}
