using System;
using System.Collections.Generic;

namespace blog.Data.Entities
{
    public partial class TblPost
    {
        public TblPost()
        {
            TblComment = new HashSet<TblComment>();
            TblPostPhoto = new HashSet<TblPostPhoto>();
        }

        public int PostId { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int? TagId { get; set; }
        public string Summary { get; set; }
        public string FullBody { get; set; }
        public int? NumLikes { get; set; }
        public DateTime? DatePublished { get; set; }
        public bool CommentsEnabled { get; set; }
        public int? NumViews { get; set; }

        public virtual TblCategory Category { get; set; }
        public virtual TblTag Tag { get; set; }
        public virtual TblUser User { get; set; }
        public virtual ICollection<TblComment> TblComment { get; set; }
        public virtual ICollection<TblPostPhoto> TblPostPhoto { get; set; }
    }
}
