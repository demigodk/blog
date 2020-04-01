using System;
using System.Collections.Generic;

namespace blog.Data.Entities
{
    public partial class TblComment
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public int? IsReplyToId { get; set; }
        public string Comment { get; set; }
        public string UserId { get; set; }
        public bool? MarkRead { get; set; }
        public bool Enabled { get; set; }
        public DateTime? DatePosted { get; set; }

        public virtual TblPost Post { get; set; }
        public virtual TblUser User { get; set; }
    }
}
